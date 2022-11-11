﻿using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Immutable;
using System.Text;

#if DEBUG
// Needed for Debugger launching
using System.Diagnostics;
#endif

namespace RefitClassSourceGenerator;

[Generator]
public class RefitClassGenerator : ISourceGenerator
{
	public void Initialize(GeneratorInitializationContext context)
	{
		context.RegisterForSyntaxNotifications(() => new RefitPromoteReceiver());
	}

	public void Execute(GeneratorExecutionContext context)
	{
		try
		{
#if DEBUG
			if (!Debugger.IsAttached)
			{
				//Debugger.Launch();
			}
#endif
			if (context.SyntaxReceiver is not RefitPromoteReceiver receiver)
			{
				throw new InvalidOperationException("Wrong type of receiver.");
			}

			var propertiesToPromote = receiver.PropertiesToPromote;

			foreach (var property in propertiesToPromote)
			{
				var semanticModel = context.Compilation.GetSemanticModel(property.SyntaxTree);

				// Find the type of the property as this is what we want to copy properties from
				// Need to get the symbol
				var propertyDeclaredSymbol = semanticModel.GetDeclaredSymbol(property);

				if (propertyDeclaredSymbol is null)
				{
					// Report an error message that we couldn't find the property
					context.ReportDiagnostic(
						Diagnostic.Create(
							new DiagnosticDescriptor(
								"RCG002",
								"Property Missing",
								$"Could not find the property {property.ToFullString()}",
								"Error",
								DiagnosticSeverity.Error,
								true), Location.None
							)
						);
					continue;
				}

				var propertyTypeName = propertyDeclaredSymbol.Type.ToDisplayString();
				var propertyInterfaceSymbols = GetMatchingInterfacesInSolution(context.Compilation, propertyTypeName);
				if (propertyInterfaceSymbols is null)
				{
					// Report an error message that we couldn't find the interface
					context.ReportDiagnostic(
						Diagnostic.Create(
							new DiagnosticDescriptor(
								"RCG003",
								"Interface Missing",
								$"Could not find the interface {propertyTypeName}",
								"Error",
								DiagnosticSeverity.Error,
								true), Location.None
							)
						);
					continue;
				}

				if (propertyInterfaceSymbols.Count != 1)
				{
					// Report an error message that we found other than 1 interface
					context.ReportDiagnostic(
						Diagnostic.Create(
							new DiagnosticDescriptor(
								"RCG004",
								"Ambiguous interface reference",
								$"Found {propertyInterfaceSymbols.Count} interface symbols for {propertyTypeName}",
								"Error",
								DiagnosticSeverity.Error,
								true), Location.None
							)
						);
					continue;
				}

				var propertyInterfaceSymbol = propertyInterfaceSymbols[0];

				// Get all the methods on the interface
				var interfaceMethodSymbols = propertyInterfaceSymbol?.GetMembers().OfType<IMethodSymbol>().ToList() ?? throw new Exception("Missing members");
				var sb = new StringBuilder(@$"
// <auto-generated />
namespace {propertyDeclaredSymbol.ContainingType.ContainingNamespace};

public partial class {propertyDeclaredSymbol.ContainingType.Name}
{{
");

				var processedAnyMethods = false;
				foreach (var methodSymbol in interfaceMethodSymbols)
				{
					if (processedAnyMethods)
					{
						sb.AppendLine();
					}

					if (methodSymbol.DeclaredAccessibility == Accessibility.Public)
					{
						sb.AppendLine("\t" + methodSymbol.GetMethodSignature(true));
						var parameters = string.Join(", ", methodSymbol.Parameters.Select(p => $"{p.Name}"));
						sb.AppendLine($"\t\t=> {propertyDeclaredSymbol.Name}.{methodSymbol.Name}({parameters});");
					}

					processedAnyMethods = true;
				}

				sb.AppendLine("}");
				var newSource = sb.ToString();
#if DEBUG
				if (!Debugger.IsAttached)
				{
					//Debugger.Launch();
				}
#endif
				context.AddSource($"{propertyDeclaredSymbol.ContainingType.Name}_{propertyDeclaredSymbol.Name}.g.cs", SourceText.From(newSource, Encoding.UTF8));
			}
		}
		catch (Exception ex)
		{
#if DEBUG
			if (!Debugger.IsAttached)
			{
				//Debugger.Launch();
			}
#endif
			context.ReportDiagnostic(Diagnostic.Create(new DiagnosticDescriptor("RCG001", "Error", ex.Message, "Error", DiagnosticSeverity.Error, true), Location.None));
		}
	}

	public IImmutableList<INamedTypeSymbol?> GetMatchingInterfacesInSolution(Compilation compilation, string name)
	{
		return compilation.SyntaxTrees.Select(syntaxTree => compilation.GetSemanticModel(syntaxTree))
			.SelectMany(
				semanticModel => semanticModel
					.SyntaxTree
					.GetRoot()
					.DescendantNodes()
					.OfType<InterfaceDeclarationSyntax>()
					.Select(interfaceDeclarationSyntax => semanticModel.GetDeclaredSymbol(interfaceDeclarationSyntax)))
			.Where(symbol => symbol != null && name == symbol.ToDisplayString())
			.ToImmutableList();
	}

	public IImmutableList<string> GetInterfaceNamesInSolution(Compilation compilation)
	{
		return compilation.SyntaxTrees.Select(syntaxTree => compilation.GetSemanticModel(syntaxTree))
			.SelectMany(
				semanticModel => semanticModel
					.SyntaxTree
					.GetRoot()
					.DescendantNodes()
					.OfType<InterfaceDeclarationSyntax>()
					.Select(interfaceDeclarationSyntax => semanticModel.GetDeclaredSymbol(interfaceDeclarationSyntax)))
			.Where(s => s is not null)
			.Select(s => s!.ToDisplayString())
			.ToImmutableList();
	}

	public static string GetNamespaceFrom(SyntaxNode s)
		=> s.Parent switch
		{
			NamespaceDeclarationSyntax namespaceDeclarationSyntax => namespaceDeclarationSyntax.Name.ToString(),
			FileScopedNamespaceDeclarationSyntax namespaceDeclarationSyntax => namespaceDeclarationSyntax.Name.ToString(),
			null => string.Empty, // or whatever you want to do
			_ => GetNamespaceFrom(s.Parent)
		};
}

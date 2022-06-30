﻿using System.Globalization;

namespace Meraki.ApiChecker.Extensions;

public static class StringExtensions
{
	public static string FirstCharToUpper(this string input)
		=> input switch
		{
			null => throw new ArgumentNullException(nameof(input)),
			"" => "",
			_ => string.Concat(input[0].ToString().ToUpper(CultureInfo.InvariantCulture), input.AsSpan(1))
		};
}
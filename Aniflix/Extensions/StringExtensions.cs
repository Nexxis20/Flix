using System.Globalization;
using System.Text;

namespace Aniflix.Extensions
{
    public static class StringExtensions
    {
        public static string RemoveDiacritics(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder(normalizedString.Length);

            foreach (char c in normalizedString)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString();
        }

        public static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException(
                    $"{nameof(input)} cannot be empty",
                    nameof(input)
                ),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1)),
            };

        public static string RemoveExcept(
            string value,
            bool alphas = false,
            bool numerics = false,
            bool dashes = false,
            bool underlines = false,
            bool spaces = false,
            bool periods = false
        )
        {
            if (string.IsNullOrWhiteSpace(value))
                return value;
            if (new[] { alphas, numerics, dashes, underlines, spaces, periods }.All(x => !x))
                return value;

            var whitelistChars = new HashSet<char>(
                string.Concat(
                        alphas ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" : "",
                        numerics ? "0123456789" : "",
                        dashes ? "-" : "",
                        underlines ? "_" : "",
                        periods ? "." : "",
                        spaces ? " " : ""
                    )
                    .ToCharArray()
            );

            var scrubbedValue = value
                .Aggregate(
                    new StringBuilder(),
                    (sb, @char) =>
                    {
                        if (whitelistChars.Contains(@char))
                            sb.Append(@char);
                        return sb;
                    }
                )
                .ToString();

            return scrubbedValue;
        }
        public static string CleanAndFormatNames(IEnumerable<string> names)
        {
            HashSet<string> uniqueNames = [];

            foreach (var name in names)
            {
                string cleanName = new(name.RemoveDiacritics().Where(char.IsAscii).ToArray());
                uniqueNames.Add($"#{FirstCharToUpper(name.Replace(" ", ""))}");
                uniqueNames.Add($"#{FirstCharToUpper(cleanName.Replace(" ", ""))}");
            }

            return string.Join(" ", uniqueNames);
        }
    }
}

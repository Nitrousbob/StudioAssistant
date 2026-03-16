using System.Text.RegularExpressions;

namespace StudioAssistant
{
    public class Validators
    {

        public static bool ContainsValue(string text)
        {
            if (string.IsNullOrWhiteSpace(text) || string.IsNullOrEmpty(text))
            {
                return false;
            }
            ;
            return true;
        }

        internal static bool IsValidEmail(string text)
        {

            // A pragmatic regex pattern for common email addresses
            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            return Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase);

        }
    }
}

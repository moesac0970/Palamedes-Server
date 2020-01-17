using System.Text.RegularExpressions;

namespace Palamedes.Lib.Extensions
{
    public class Validation
    {
        /// <summary>Checks whether the supplied string is a valid email address</summary>
        /// <param name="s">String to validate</param>
        /// <returns>Return true when the supplied string is a valid email address</returns>
        public bool IsValidEmailAddress(string s)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(s);
        }

        /// <summary>Checks whether the supplied string is a valid password</summary>
        /// <param name="s">String to validate</param>
        /// <returns>Returns true when the supplied string is a valid password</returns>
        public bool IsValidPassworld(string s)
        {
            // 6 to 12 characters in length
            // At least one uppercase letter
            // At least one lower case letter
            // At least one digit
            // Should contain other characters

            Regex regex = new Regex(@"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d).{ 6, 12 }$");
            return regex.IsMatch(s);
        }

        /// <summary>Checks whether the supplied string is a valid URL</summary>
        /// <param name="s">String to validate</param>
        /// <returns>Returns true when the supplied string is a valid URL</returns>
        public bool IsValidUrl(string s)
        {
            // Must start with http or https followed by ://
            // Must match a valid domain name
            // Could contain a port specification
            // Could contain digit, letter, dots, hyphens, forward slashes, multiple times

            Regex regex = new Regex(@"^(http|https):[\/]{2}([a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,4})(:[0-9]+)?\/?([a-zA-Z0-9\-\._\?\,\'\/\\\+&amp;%\$#\=~]*)");
            return regex.IsMatch(s);
        }

        /// <summary>Checks whether the supplied string is a valid internation phone number</summary>
        /// <param name="s">String to validate</param>
        /// <returns>Returns true when the supplied string is a valid international phone number</returns>
        public bool IsValidPhoneNumber(string s)
        {
            Regex regex = new Regex(@"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\d{1,14}$");
            return regex.IsMatch(s);
        }

        /// <summary>Checks whether the supplied string contains HTML tags</summary>
        /// <param name="s">String to validate</param>
        /// <returns>Returns true when the supplied string contains HTML tags</returns>
        public bool ContainsHtmlTags(string s)
        {
            Regex regex = new Regex(@"<([\w]+).*>(.*?)<\/\1>");
            return regex.IsMatch(s);
        }
    }
}

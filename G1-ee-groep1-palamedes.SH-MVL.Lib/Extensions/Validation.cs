using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace G1_ee_groep1_palamedes.SH_MVL.Lib.Extensions
{
    static class Validation
    {
        /// <summary>Checks whether the supplied string is a valid email address</summary>
        /// <param name="s">String to validate</param>
        /// <returns>Return true when the supplied string is a valid email address</returns>
        public static bool IsValidEmailAddress(this string s)
        {
            Regex regex = new Regex(@"^\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return regex.IsMatch(s);
        }

        /// <summary>Checks whether the supplied string is a valid password</summary>
        /// <param name="s">String to validate</param>
        /// <returns>Returns true when the supplied string is a valid password</returns>
        public static bool IsValidPassworld(this string s)
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
        public static bool IsValidUrl(this string s)
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
        public static bool IsValidPhoneNumber(this string s)
        {
            Regex regex = new Regex(@"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8[6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\d{1,14}$");
            return regex.IsMatch(s);
        }
    }
}

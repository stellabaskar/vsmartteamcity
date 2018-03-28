using MVC5RealWorld.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace MVC5RealWorld.Helpers1
{
    public static class Util
    {
        public static string appVersion = ConfigurationManager.AppSettings["Version"];
        public static string[] DemoVersionMonthsAndYears = ConfigurationManager.AppSettings["DemoVersionMonthsAndYears"].Split(new string[]{","},StringSplitOptions.RemoveEmptyEntries);
        public static string[] FullVersionMonthsAndYears = ConfigurationManager.AppSettings["FullVersionMonthsAndYears"].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
        public static DateTime getDateFromString(string date)
        {
            DateTime formattedDate = new DateTime();
            try
            {
                string format = "yyyy-MM-dd";
                System.Globalization.CultureInfo provider = System.Globalization.CultureInfo.InvariantCulture;
                formattedDate = DateTime.ParseExact(date, format, provider);
            }
            catch (Exception e) { };
            return formattedDate;
        }

        public static bool FindClaim(string claimToFind, IPrincipal User)
        {
            var identity = (ClaimsIdentity)User.Identity;
            var UserCalendarAccessId = identity.Claims.Where(claim => claim.Value == claimToFind && claim.Type.ToLower().Contains("calendar")).FirstOrDefault();

            return UserCalendarAccessId == null ? false : true;
        }
        public static int ConvertToInt(string number)
        {
            int result=0;
            try
            {
                result = Convert.ToInt32(number);
            }
            catch
            {

            }
            return result;
        }
    }
    public class SemiNumericComparer : IComparer<string>
    {
        public int Compare(string s1, string s2)
        {
            if (IsNumeric(s1) && IsNumeric(s2))
            {
                if (Convert.ToInt32(s1) > Convert.ToInt32(s2)) return 1;
                if (Convert.ToInt32(s1) < Convert.ToInt32(s2)) return -1;
                if (Convert.ToInt32(s1) == Convert.ToInt32(s2)) return 0;
            }

            if (IsNumeric(s1) && !IsNumeric(s2))
                return -1;

            if (!IsNumeric(s1) && IsNumeric(s2))
                return 1;

            return string.Compare(s1, s2, true);
        }

        public static bool IsNumeric(object value)
        {
            try
            {
                int i = Convert.ToInt32(value.ToString());
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
    public class AlphanumComparatorFast : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            string s1 = x as string;
            if (s1 == null)
            {
                return 0;
            }
            string s2 = y as string;
            if (s2 == null)
            {
                return 0;
            }

            int len1 = s1.Length;
            int len2 = s2.Length;
            int marker1 = 0;
            int marker2 = 0;

            // Walk through two the strings with two markers.
            while (marker1 < len1 && marker2 < len2)
            {
                char ch1 = s1[marker1];
                char ch2 = s2[marker2];

                // Some buffers we can build up characters in for each chunk.
                char[] space1 = new char[len1];
                int loc1 = 0;
                char[] space2 = new char[len2];
                int loc2 = 0;

                // Walk through all following characters that are digits or
                // characters in BOTH strings starting at the appropriate marker.
                // Collect char arrays.
                do
                {
                    space1[loc1++] = ch1;
                    marker1++;

                    if (marker1 < len1)
                    {
                        ch1 = s1[marker1];
                    }
                    else
                    {
                        break;
                    }
                } while (char.IsDigit(ch1) == char.IsDigit(space1[0]));

                do
                {
                    space2[loc2++] = ch2;
                    marker2++;

                    if (marker2 < len2)
                    {
                        ch2 = s2[marker2];
                    }
                    else
                    {
                        break;
                    }
                } while (char.IsDigit(ch2) == char.IsDigit(space2[0]));

                // If we have collected numbers, compare them numerically.
                // Otherwise, if we have strings, compare them alphabetically.
                string str1 = new string(space1);
                string str2 = new string(space2);

                int result;

                if (char.IsDigit(space1[0]) && char.IsDigit(space2[0]))
                {
                    int thisNumericChunk = int.Parse(str1);
                    int thatNumericChunk = int.Parse(str2);
                    result = thisNumericChunk.CompareTo(thatNumericChunk);
                }
                else
                {
                    result = str1.CompareTo(str2);
                }

                if (result != 0)
                {
                    return result;
                }
            }
            return len1 - len2;
        }
    }
}
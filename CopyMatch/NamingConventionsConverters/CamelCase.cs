using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;
using System.Text.RegularExpressions;

namespace CopyMatch.NamingConventionsConverters
{
    /// <summary>
    /// CamelCase
    /// </summary>
    public class CamelCase : INamingConvention
    {
        public string ThisToString(string inputString)
        {
            string normalText = inputString[0].ToString().ToLower();
            for (int i = 1; i < inputString.Length; i++)
            {
                if (IsLower(inputString[i]))
                {
                    normalText += inputString[i];
                }
                else if (IsUpper(inputString[i]))
                {
                    normalText += " " + inputString[i].ToString().ToLower();
                }
            }

            return normalText;
        }

        public string StringToThis(string inputString)
        {
            string normalText = inputString[0].ToString().ToUpper();
            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] != ' ')
                {
                    normalText += inputString[i];
                }
                else
                {
                    i++;
                    normalText += inputString[i].ToString().ToUpper();
                }
            }

            return normalText;
        }

        public bool IsTypeOfThis(string inputString)
        {
            string pattern = "[a-zA-Z]";
            Regex rgx = new Regex(pattern);
            return rgx.IsMatch(inputString);
        }

        private bool IsLower(char input)
        {
            return input.ToString() == input.ToString().ToLower();
        }

        private bool IsUpper(char input)
        {
            return input.ToString() == input.ToString().ToUpper();
        }
    }
}

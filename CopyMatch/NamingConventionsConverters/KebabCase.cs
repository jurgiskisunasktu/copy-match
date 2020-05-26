using System;
using System.Collections.Generic;
using System.Text;

namespace CopyMatch.NamingConventionsConverters
{
    /// <summary>
    /// kebab-case
    /// </summary>
    public class KebabCase : INamingConvention
    {
        public string ThisToString(string inputString)
        {
            string[] words = inputString.Split('-');
            string normalText = "";
            for (int i = 0; i < words.Length - 1; i++)
            {
                normalText += words[i] + " ";
            }

            normalText += words[^1];
            return normalText;
        }

        public string StringToThis(string inputString)
        {
            return inputString.Replace(' ', '-');
        }

        public bool IsTypeOfThis(string inputString)
        {
            return inputString.Contains('-');
        }
    }
}

namespace CopyMatch.NamingConventionsConverters
{
    /// <summary>
    /// For the snake case conversion that looks like this: snake_case
    /// </summary>
    public class SnakeCase : INamingConvention
    {
        public string ThisToString(string inputString)
        {
            string[] words = inputString.Split('_');
            string normalText = "";
            for (int i = 0; i < words.Length-1; i++)
            {
                normalText += words[i] + " ";
            }

            normalText += words[^1];
            return normalText;
        }

        public string StringToThis(string inputString)
        {
            return inputString.Replace(' ', '_');
        }

        public bool IsTypeOfThis(string inputString)
        {
            return inputString.Contains('_');
        }
    }
}

namespace CopyMatch.NamingConventionsConverters
{
    public static class NamingConventionConverter
    {
        private static CamelCase camelCase = new CamelCase();
        private static KebabCase kebabCase = new KebabCase();
        private static SnakeCase snakeCase = new SnakeCase();

        public static string ToCamelCase(this string normalText)
        {
            return camelCase.StringToThis(normalText);
        }

        public static string ToSnakeCase(this string normalText)
        {
            return snakeCase.StringToThis(normalText);
        }

        public static string ToKebabCase(this string normalText)
        {
            return kebabCase.StringToThis(normalText);
        }

        public static INamingConvention GetNamingConvention(string propertyName)
        {
            if (kebabCase.IsTypeOfThis(propertyName)) return kebabCase;
            if (snakeCase.IsTypeOfThis(propertyName)) return snakeCase;
            if (camelCase.IsTypeOfThis(propertyName)) return camelCase;
            return null;
        }
    }
}

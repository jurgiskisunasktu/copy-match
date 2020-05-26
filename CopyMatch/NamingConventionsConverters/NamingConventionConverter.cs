namespace CopyMatch.NamingConventionsConverters
{
    public class NamingConventionConverter
    {
        private CamelCase camelCase;
        private KebabCase kebabCase;
        private SnakeCase snakeCase;

        public NamingConventionConverter()
        {
            camelCase = new CamelCase();
            kebabCase = new KebabCase();
            snakeCase = new SnakeCase();
        }

        public INamingConvention GetNamingConvention(string propertyName)
        {
            if (camelCase.IsTypeOfThis(propertyName)) return camelCase;
            if (kebabCase.IsTypeOfThis(propertyName)) return kebabCase;
            if (snakeCase.IsTypeOfThis(propertyName)) return snakeCase;
            return null;
        }
    }
}

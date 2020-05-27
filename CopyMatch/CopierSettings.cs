namespace CopyMatch
{
    public class CopierSettings : Singleton<CopierSettings>
    {
        public bool CamelCaseToSnakeCaseConvertionEnabled = true;
        public bool CamelCaseToKebabCaseConvertionEnabled = true;

        public bool SnakeCaseToCamelCaseConvertionEnabled = true;
        public bool SnakeCaseToKebabCaseConvertionEnabled = true;

        public bool KebabCaseToCamelCaseConvertionEnabled = true;
        public bool KebabCaseToSnakeCaseConvertionEnabled = true;

        public CopierSettings() {}
    }
}

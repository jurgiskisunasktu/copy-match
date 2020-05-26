namespace CopyMatch
{
    public class CopierSettings : Singleton<CopierSettings>
    {
        public bool CamelCaseAccepted = true;
        public bool SnakeCaseAccepted = false;
        public bool KebabCaseAccepted = false;

        public CopierSettings() {}
    }
}

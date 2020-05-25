namespace CopyMatch
{
    public static class CopierHelper
    {
        public static object CopyToOtherClass(this object target, object source)
        {
            Copier copier = new Copier();
            copier.Copy(source, target);

            return target;
        }
    }
}

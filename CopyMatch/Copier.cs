using System;
using System.Reflection;

namespace CopyMatch
{
    public class Copier
    {
        public void Copy(object source, object target)
        {
            Type typeB = target.GetType();
            foreach (PropertyInfo property in source.GetType().GetProperties())
            {
                if (!property.CanRead || (property.GetIndexParameters().Length > 0))
                    continue;

                PropertyInfo other = typeB.GetProperty(property.Name);
                if ((other != null) && (other.CanWrite))
                    other.SetValue(target, property.GetValue(source, null), null);
            }
        }
    }
}

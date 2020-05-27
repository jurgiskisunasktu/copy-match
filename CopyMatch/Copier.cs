using System;
using System.Reflection;
using CopyMatch.NamingConventionsConverters;

namespace CopyMatch
{
    public class Copier
    {
        public void Copy(object source, object target)
        {
            Type typeTarget = target.GetType();
            foreach (PropertyInfo property in source.GetType().GetProperties())
            {
                if (!property.CanRead || (property.GetIndexParameters().Length > 0))
                    continue;

                PropertyInfo other = GetPropertyInfo(typeTarget, property.Name);
                if ((other != null) && (other.CanWrite))
                    other.SetValue(target, property.GetValue(source, null), null);
            }
        }

        private PropertyInfo GetPropertyInfo(Type typeTarget, string propertyName)
        {
            PropertyInfo propertyInfo = typeTarget.GetProperty(propertyName);
            if (propertyInfo != null) return propertyInfo;

            INamingConvention namingConvention = NamingConventionConverter.GetNamingConvention(propertyName);

            string normalText = namingConvention.ThisToString(propertyName);

            if (namingConvention.GetType() == typeof(CamelCase)
                && CopierSettings.Instance.CamelCaseToSnakeCaseConvertionEnabled)
            {
                propertyInfo = typeTarget.GetProperty(normalText.ToSnakeCase());
                if (propertyInfo != null) return propertyInfo;
            }

            if (namingConvention.GetType() == typeof(CamelCase)
                && CopierSettings.Instance.CamelCaseToKebabCaseConvertionEnabled)
            {
                propertyInfo = typeTarget.GetProperty(normalText.ToKebabCase());
                if (propertyInfo != null) return propertyInfo;
            }

            if (namingConvention.GetType() == typeof(SnakeCase)
                && CopierSettings.Instance.SnakeCaseToCamelCaseConvertionEnabled)
            {
                propertyInfo = typeTarget.GetProperty(normalText.ToCamelCase());
                if (propertyInfo != null) return propertyInfo;
            }
            
            if (namingConvention.GetType() == typeof(SnakeCase)
                && CopierSettings.Instance.SnakeCaseToKebabCaseConvertionEnabled)
            {
                propertyInfo = typeTarget.GetProperty(normalText.ToKebabCase());
                if (propertyInfo != null) return propertyInfo;
            }
            
            if (namingConvention.GetType() == typeof(KebabCase)
                && CopierSettings.Instance.KebabCaseToCamelCaseConvertionEnabled)
            {
                propertyInfo = typeTarget.GetProperty(normalText.ToCamelCase());
                if (propertyInfo != null) return propertyInfo;
            }
            
            if (namingConvention.GetType() == typeof(KebabCase)
                && CopierSettings.Instance.KebabCaseToSnakeCaseConvertionEnabled)
            {
                propertyInfo = typeTarget.GetProperty(normalText.ToSnakeCase());
                if (propertyInfo != null) return propertyInfo;
            }

            return null;
        }
    }
}

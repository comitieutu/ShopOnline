using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ComiShop.Data.Entities
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class DefaultDateTimeValueAttribute : ValidationAttribute
    {
        public string DefaultValue { get; set; }

        public DefaultDateTimeValueAttribute(string defaultValue)
        {
            DefaultValue = defaultValue;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PropertyInfo property = validationContext.ObjectType.GetProperty(validationContext.MemberName);

            if (value == null)
            {
                DateTime defaultValue = GetDefaultValue();
                property.SetValue(validationContext.ObjectInstance, defaultValue);
            }

            return ValidationResult.Success;
        }

        private DateTime GetDefaultValue()
        {
            if (this.IsProperty)
            {
                return GetPropertyValue();
            }

            return GetAbsoluteValue();
        }
        private bool IsProperty => typeof(DateTime).GetProperties().Select(p => p.Name).Contains(this.DefaultValue);

        private DateTime GetPropertyValue()
        {
            var instance = Activator.CreateInstance<DateTime>();
            var value = (DateTime)instance.GetType()
                .GetProperty(this.DefaultValue)
                .GetValue(instance);

            return value;
        }
        private DateTime GetAbsoluteValue()
        {
            DateTime value;
            if (!DateTime.TryParse(this.DefaultValue, out value))
            {
                return default(DateTime);
            }

            return value;
        }
    }
}

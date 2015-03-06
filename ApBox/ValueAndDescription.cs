using System.ComponentModel;
using System.Reflection;

namespace ApBox
{
    public class ValueAndDescription
    {
        public ValueAndDescription(ViewModel.NestedEnum value)
        {
            Value = value;
            var type = value.GetType();
            var field = type.GetField(value.ToString());
            var descriptionAttribute =(DescriptionAttribute) field.GetCustomAttribute(typeof(DescriptionAttribute));
            Description = descriptionAttribute.Description;
        }

        public ViewModel.NestedEnum Value { get; private set; }

        public string Description { get; private set; }
    }
}
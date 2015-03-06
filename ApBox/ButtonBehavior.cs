using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace ApBox
{
    public static class ButtonBehavior
    {
        public static readonly DependencyProperty GeometryProperty = DependencyProperty.RegisterAttached(
            "Geometry",
            typeof (Geometry), 
            typeof (ButtonBehavior),
            new PropertyMetadata(default(Geometry)));

        public static void SetGeometry(this ButtonBase element, Geometry value)
        {
            element.SetValue(GeometryProperty, value);
        }

        public static Geometry GetGeometry(this ButtonBase element)
        {
            return (Geometry) element.GetValue(GeometryProperty);
        }
    }
}

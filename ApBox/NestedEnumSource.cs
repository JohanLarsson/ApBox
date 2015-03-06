using System;
using System.Collections.Generic;
using System.Linq;

namespace ApBox
{
    public static class NestedEnumSource
    {
        public static IEnumerable<MainWindow.NestedEnum> Members
        {
            get
            {
                return Enum.GetValues(typeof(MainWindow.NestedEnum))
                    .Cast<MainWindow.NestedEnum>();
            }
        }
    }
}
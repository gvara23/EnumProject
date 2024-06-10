using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProject
{
    public enum Ecolors
    {
        [Description("Red")]
        Red,
        [Description("Blue")]
        Blue,
        [Description("Green")]
        Green,
        [Description("Yellow")]
        Yellow
    }
}

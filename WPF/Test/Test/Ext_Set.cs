using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class Ext_Set
    {
        public static T Set<T>(this T _this, System.Action<T> _act){_act(_this);return _this;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger
{
    public static class Ext_String
    {
        public static byte[] Get_Encoding_UTF8_Bytes(this System.String _this) { return Encoding.UTF8.GetBytes(_this); }
    }
}

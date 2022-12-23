using System.Linq;
using System.Text;
using System;
///////////////////////////////////////////////////////////////
using Binarysharp.Assemblers.Fasm;
using Process.NET;
using Process.NET.Native.Types;
///////////////////////////////////////////////////////////////
using System.Runtime.InteropServices;
using System.Security;
///////////////////////////////////////////////////////////////

namespace System
{
    public static class Ext_IAllocatedMemory
    {
        public static T Get_GetDelegate<T>(this Process.NET.Memory.IAllocatedMemory _this) where T : System.Delegate
        { return Marshal.GetDelegateForFunctionPointer<T>(_this.BaseAddress); }
        public static Process.NET.Memory.IAllocatedMemory Get_GetDelegate<T>(this Process.NET.Memory.IAllocatedMemory _this, out T _Delegate) where T : System.Delegate
        {
            _Delegate = _this.Get_GetDelegate<T>();
            return _this;
        }
        public static Process.NET.Memory.IAllocatedMemory Write_(this Process.NET.Memory.IAllocatedMemory _this, int offset, byte[] toWrite)
        { _this.Write(offset, toWrite); return _this; }
    }

}

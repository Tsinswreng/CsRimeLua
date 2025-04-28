using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsRimeLua.Core.Lua_5_4;
using Lua_State = System.IntPtr;
using _ = CsRimeLua.Exports.Time.Ext_Time;
using CsRimeLua.Core.Logger_;
class Ext_Time {
	[UnmanagedCallersOnly(EntryPoint = nameof(GetUnixTimeMs), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 GetUnixTimeMs(Lua_State L){
		return _.GetUnixTimeMs(L);
	}

	[UnmanagedCallersOnly(EntryPoint = nameof(GetWeekOfYear), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 GetWeekOfYear(Lua_State L){
		return _.GetWeekOfYear(L);
	}
}

#if false
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsRimeLua.Core.Lua_5_4;
using Lua_State = System.IntPtr;
using _ = CsRimeLua.Exports.Time.Ext_Time;
class Ext_Time {
	[UnmanagedCallersOnly(EntryPoint = nameof(GetUnixTimeMs), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 GetUnixTimeMs(Lua_State L){
		return _.GetUnixTimeMs(L);
	}

	[UnmanagedCallersOnly(EntryPoint = nameof(GetWeekOfYear), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 GetWeekOfYear(Lua_State L){
		return _.GetWeekOfYear(L);
	}
}
#endif
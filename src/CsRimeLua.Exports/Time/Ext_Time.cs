namespace CsRimeLua.Exports.Time;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsRimeLua.Core.Logger_;
using CsRimeLua.Core.Lua_5_4;
using Lua_State = System.IntPtr;

unsafe public partial class Ext_Time{
	//[UnmanagedCallersOnly(EntryPoint = nameof(GetUnixTimeMs), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static nil Log(str Msg){
		return Logger.Inst.Log(Msg);
	}
	public static i32 GetUnixTimeMs(Lua_State L){
		var Lua = DllLoader.GetLuaApi();
		i64 ans = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		Lua.lua_pushinteger(L, ans); 
		return 1;
	}

	//[UnmanagedCallersOnly(EntryPoint = nameof(GetWeekOfYear), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 GetWeekOfYear(Lua_State L){
		var Lua = DllLoader.GetLuaApi();
		var today =  DateTime.Today;
		var isoWeek = ISOWeek.GetWeekOfYear(today);
		//var isoYear = ISOWeek.GetYear(today);
		Lua.lua_pushinteger(L, isoWeek);
		return 1;
	}
}
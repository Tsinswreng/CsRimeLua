
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using Lua_State = System.IntPtr;

unsafe public partial class Export_Time{
	[UnmanagedCallersOnly(EntryPoint = nameof(getUnixTimeMillis), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static int getUnixTimeMillis(Lua_State L){
		var lua = DllLoader.GetLuaApi();
		i64 ans = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		lua_pushinteger(L, ans);
		return 1;
	}

	[UnmanagedCallersOnly(EntryPoint = nameof(getWeekOfYear), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 getWeekOfYear(Lua_State L){
		var today =  DateTime.Today;
		var isoWeek = ISOWeek.GetWeekOfYear(today);
		//var isoYear = ISOWeek.GetYear(today);
		lua_pushinteger(L, isoWeek);
		return 1;
	}
}
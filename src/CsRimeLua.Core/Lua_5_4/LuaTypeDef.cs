using System.Runtime.InteropServices;

namespace CsRimeLua.Core.Lua_5_4;

/// <summary>
/// typedef int (*lua_KFunction) (lua_State *L, int status, lua_KContext ctx);
/// Type for continuation functions (see §4.5).
/// </summary>
/// <param name="L"></param>
/// <param name="status"></param>
/// <param name="ctx"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_KFunction(
	lua_State L
	,i32 status
	,lua_KContext ctx
);
namespace CsRimeLua.Exports._G;

using CsRimeLua.Core;
using CsRimeLua.Core.Lua_5_4;
using Lua_State = System.IntPtr;
unsafe public static class Ext__G{

	public static void test(Lua_State L){
		var lua = DllLoader.GetLuaApi();
		lua.luaL_checktype(L, 1, LuaConsts.LUA_TTABLE);//?
		
	}
}
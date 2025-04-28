namespace CsRimeLua.Core.Lua_5_4;

public partial class LuaMacroFn(LuaApi Lua){
	public LuaApi Lua{get;set;} = Lua;
	/// <summary>
	/// #define lua_pop(L,n)		lua_settop(L, -(n)-1)
	/// </summary>
	public void lua_pop(Lua_State L, i32 n){
		Lua.lua_settop(L, -(n)-1);
	}
}
namespace CsRimeLua.Core.Lua_5_4;

unsafe public partial class LuaConf{
	public i32 LUAI_MAXSTACK;
	public i32 LUA_REGISTRYINDEX;
	public LuaConf(){
		LUAI_MAXSTACK = 1000000;
		LUA_REGISTRYINDEX = (-LUAI_MAXSTACK - 1000);
	}
}
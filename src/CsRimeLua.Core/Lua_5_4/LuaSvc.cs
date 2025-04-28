namespace CsRimeLua.Core.Lua_5_4;

public class LuaSvc{
	public LuaMacroFn MacroFn;
	public LuaApi Api;
	public LuaConf Conf = new LuaConf();
	public LuaSvc(LuaApi LuaApi){
		Api = LuaApi;
		MacroFn = new LuaMacroFn(LuaApi);
	}
}
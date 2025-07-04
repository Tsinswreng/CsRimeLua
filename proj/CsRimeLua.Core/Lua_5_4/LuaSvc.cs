namespace CsRimeLua.Core.Lua_5_4;

public class LuaSvc{
	public LuaMacroFn MacroFn{get;set;}
	public LuaApi Api{get;set;}
	public LuaConf Conf{get;set;} = new LuaConf();
	public LuaU8StrFn U8StrFn{get;set;}
	public LuaSvc(LuaApi LuaApi){
		Api = LuaApi;
		MacroFn = new LuaMacroFn(LuaApi);
		U8StrFn = new LuaU8StrFn(LuaApi);
	}
}
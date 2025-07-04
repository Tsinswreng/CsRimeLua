namespace CsRimeLua.Core.Lua_5_4;

unsafe public class LuaHelper{
	public lua_State L;
	public LuaHelper(lua_State L) {
		this.L = L;
	}
	public LuaSvc Svc{get;set;}


	LuaHelper F(ReadOnlySpan<u8> field){
		fixed(u8* cStr = field){
			Svc.Api.lua_getfield(L, -1, cStr);
		}
		return this;
	}

}
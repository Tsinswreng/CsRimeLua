namespace CsRimeLua.Core.Lua_5_4;
using Str = ReadOnlySpan<u8>;
unsafe public class LuaU8StrFn(LuaApi Lua){
	public LuaApi Api{get;set;} = Lua;

	public i32 lua_getglobal(lua_State L, Str name){
		fixed(u8* ptr = name){
			return Api.lua_getglobal(L, ptr);
		}
	}

	public i32 lua_getfield(lua_State L, i32 index, Str k){
		fixed(u8* ptr = k){
			return Api.lua_getfield(L, index, ptr);
		}
	}

	public void lua_pushstring(lua_State L, Str s){
		fixed(u8* ptr = s){
			Api.lua_pushstring(L, ptr);
		}
	}
}
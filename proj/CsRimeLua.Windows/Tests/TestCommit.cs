using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsRimeLua.Core.Logger_;
using CsShared.Interop;

namespace CsRimeLua.Windows.Tests;

unsafe public class TestCommit : _BaseTest{
	//[UnmanagedCallersOnly(EntryPoint = nameof(Test), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 Test(lua_State L){
		try{
			i=0;
			var Svc = LuaDll.GetLuaSvc();
			var Api = Svc.Api;
			var U8Fn = Svc.U8StrFn;
			u8* input_c = Api.lua_tolstring(L, 1, null);
			str? input = CStrUtil.ToCsStr(input_c);
			IntPtr segment = Api.lua_touserdata(L, 2);
			IntPtr env = Api.lua_touserdata(L, 3);
			var rf_env = Api.luaL_ref(L, Svc.Conf.LUA_REGISTRYINDEX);
			var rf_segment = Api.luaL_ref(L, Svc.Conf.LUA_REGISTRYINDEX);
			var rf_input = Api.luaL_ref(L, Svc.Conf.LUA_REGISTRYINDEX);
			Api.luaL_unref(L, Svc.Conf.LUA_REGISTRYINDEX, rf_input);
			if(input == "??"){
				Api.lua_rawgeti(L, Svc.Conf.LUA_REGISTRYINDEX, rf_env);//[env]
				U8Fn.lua_getfield(L, -1, "engine"u8);//[env, engine]
				var rf_engine = Api.luaL_ref(L, Svc.Conf.LUA_REGISTRYINDEX);//[env]
				Api.lua_rawgeti(L, Svc.Conf.LUA_REGISTRYINDEX, rf_engine);//[env, engine]
				U8Fn.lua_getfield(L, -1, "commit_text"u8);//[env, engine, commit_text]
				var rf_commit_text = Api.luaL_ref(L, Svc.Conf.LUA_REGISTRYINDEX);//[env, engine]
				Svc.MacroFn.lua_pop(L, 2);//[]
				Api.lua_rawgeti(L, Svc.Conf.LUA_REGISTRYINDEX, rf_commit_text);//[commit_text]
				Api.lua_rawgeti(L, Svc.Conf.LUA_REGISTRYINDEX, rf_engine);//[commit_text, engine]
				U8Fn.lua_pushstring(L, "IAmTextToCommit"u8);//[commit_text, engine, "IAmTextToCommit"]
				Svc.MacroFn.lua_call(L, 2, 0);//[]
			}
		}
		catch (System.Exception e){
			Logger.Log_(e.ToString());
			throw;
		}
		return 0;
	}

}
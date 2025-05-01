//2025-04-28T16:36:32.325+08:00_W18-1
// dotnet publish -c Release -r win-x86
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsRimeLua.Core.Logger_;
using CsShared.Interop;
using CsRimeLua.Core.Str.Extn;
unsafe class TestGlobal{

	static void I(){
		Logger.Log_(i+++"");
	}

	static i32 i = 0;//L_ogger.Log_((i++).ToString());
	[UnmanagedCallersOnly(EntryPoint = nameof(Test), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 Test(lua_State L){
		i=0;
		var svc = DllLoader.GetLuaSvc();
		var api = svc.Api;
		var U8Fn = svc.U8StrFn;
		//ReadOnlySpan<byte> cStr = "hello\0"u8;
		
		try{
			u8* input_c = api.lua_tolstring(L, 1, null);
			str? input = CStrUtil.ToCsStr(input_c);
			IntPtr segment = api.lua_touserdata(L, 2);
			IntPtr env = api.lua_touserdata(L, 3);
			var rf_env = api.luaL_ref(L, svc.Conf.LUA_REGISTRYINDEX);
			var rf_segment = api.luaL_ref(L, svc.Conf.LUA_REGISTRYINDEX);
			var rf_input = api.luaL_ref(L, svc.Conf.LUA_REGISTRYINDEX);
			api.luaL_unref(L, svc.Conf.LUA_REGISTRYINDEX, rf_input);

			U8Fn.lua_getglobal(L, "log"u8);//全局log入棧
			U8Fn.lua_getfield(L, -1, "warning"u8);//stack[-1](即log)入棧。-1潙棧頂
			U8Fn.lua_pushstring(L, "殺殺殺殺殺殺殺"u8);//參數1
			svc.MacroFn.lua_call(L, 1, 0); // 1個參數，0個返回值
			
			if(input == "??"){
				//創建Candidate對象
				U8Fn.lua_getglobal(L, "Candidate"u8);
				U8Fn.lua_pushstring(L, "type"u8);
				// U8Fn.lua_getfield(L, 2, "_start"u8);
				// U8Fn.lua_getfield(L, 2, "_end"u8);
				api.lua_pushinteger(L, 0);
				api.lua_pushinteger(L, 0);
				U8Fn.lua_pushstring(L, "text"u8);
				U8Fn.lua_pushstring(L, "comment"u8);
				svc.MacroFn.lua_call(L, 5, 1); // 5個參數，1個返回值
				
				//調用yield(cand)
				U8Fn.lua_getglobal(L, "yield"u8);
				api.lua_pushvalue(L, -2);
				svc.MacroFn.lua_call(L, 1, 0);
				svc.MacroFn.lua_pop(L, 1); // 清除返回值
			}
			api.lua_pushnil(L);
			api.lua_pushnil(L);
		}
		catch (System.Exception e){
			Logger.Log_(e.ToString());
		}
		return 2;
	}
}

/* 
function func(input: string, segment: Segment, env: Env)
	log.info(env.name_space)
	if input == "??" then
		local cand = Candidate(
			"type"
			,segment._start
			,segment._end
			,"text"
			,"comment"
		)
		yield_(cand)
	end
end

local logicFn = package.loadlib("myDll.dll", "Test")

function func(input: string, segment: Segment, env: Env)
	local ret, err = logicFn(input, segment, env)
end

 */


/* 
E20250428 20:08:47.796892 15556 modules.cc:46] rime.lua error: bad argument #2 to '?' (string expected, got nil)
 */

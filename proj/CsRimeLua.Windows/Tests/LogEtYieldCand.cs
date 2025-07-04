//2025-04-28T16:36:32.325+08:00_W18-1
// dotnet publish -c Release -r win-x86
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsRimeLua.Core.Logger_;
using CsShared.Interop;
using CsRimeLua.Core.Str.Extn;
namespace CsRimeLua.Windows.Tests;
unsafe class LogEtYieldCand{

	static i32 CandidateCont(lua_State L, i32 status, lua_KContext ctx){
		// 处理Candidate创建后的逻辑
		return 1; // 返回值数量
	}

	static i32 YieldCont(lua_State L, i32 status, lua_KContext ctx) {
		// 处理yield后的逻辑
		return 0;
	}


	static void I(){
		Logger.Log_(i+++"");
	}

	static i32 i = 0;//L_ogger.Log_((i++).ToString());
	[UnmanagedCallersOnly(EntryPoint = nameof(Test), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 Test(lua_State L){
		i=0;
		var Svc = LuaDll.GetLuaSvc();
		var Api = Svc.Api;
		var U8Fn = Svc.U8StrFn;
		//ReadOnlySpan<byte> cStr = "hello\0"u8;
		
		try{
			u8* input_c = Api.lua_tolstring(L, 1, null);
			str? input = CStrUtil.ToCsStr(input_c);
			IntPtr segment = Api.lua_touserdata(L, 2);
			IntPtr env = Api.lua_touserdata(L, 3);
			var rf_env = Api.luaL_ref(L, Svc.Conf.LUA_REGISTRYINDEX);
			var rf_segment = Api.luaL_ref(L, Svc.Conf.LUA_REGISTRYINDEX);
			var rf_input = Api.luaL_ref(L, Svc.Conf.LUA_REGISTRYINDEX);
			Api.luaL_unref(L, Svc.Conf.LUA_REGISTRYINDEX, rf_input);

			U8Fn.lua_getglobal(L, "log"u8);//[log]
			U8Fn.lua_getfield(L, -1, "warning"u8);//[log, warning]
			U8Fn.lua_pushstring(L, "殺殺殺殺殺殺殺"u8);//[log, warning, "殺殺殺殺殺殺殺"]
			Svc.MacroFn.lua_call(L, 1, 0); // [] 1個參數，0個返回值
			if(input == "??"){
				//創建Candidate對象 local cand = Candidate("type", 0, 0, "text", "comment")
				U8Fn.lua_getglobal(L, "Candidate"u8);// [Candidate]
				U8Fn.lua_pushstring(L, "type"u8); // [Candidate, "type"]
				// U8Fn.lua_getfield(L, 2, "_start"u8);
				// U8Fn.lua_getfield(L, 2, "_end"u8);
				Api.lua_pushinteger(L, 0); //[Candidate, "type", 0]
				Api.lua_pushinteger(L, 0);	//[Candidate, "type", 0, 0]
				U8Fn.lua_pushstring(L, "Hello From C#"u8); //[Candidate, "type", 0, 0, "text"]
				U8Fn.lua_pushstring(L, "我是註釋"u8); //[Candidate, "type", 0, 0, "text", "comment"]
				Svc.MacroFn.lua_call(L, 5, 1); // 5個參數，1個返回值 //[cand] 
				 
				//調用yield(cand)
				U8Fn.lua_getglobal(L, "yield"u8); //[cand, yield]
				Api.lua_pushvalue(L, -2); //[cand, yield, cand]
				//Svc.MacroFn.lua_call(L, 1, 0); // [cand]
				Api.lua_callk(L, 1, 0, IntPtr.Zero, YieldCont);
				Svc.MacroFn.lua_pop(L, 1); // []
			}
			Api.lua_pushnil(L);
			Api.lua_pushnil(L);
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

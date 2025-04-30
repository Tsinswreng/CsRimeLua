//2025-04-28T16:36:32.325+08:00_W18-1

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsRimeLua.Core.Logger_;
using CsShared.Interop;
using CsShared.Interop.Extn;
unsafe class TestGlobal{
	static i32 i = 0;//L_ogger.Log_((i++).ToString());
	[UnmanagedCallersOnly(EntryPoint = nameof(Test), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 Test(lua_State L){
		i=0;
		var svc = DllLoader.GetLuaSvc();
		var api = svc.Api;
		//ReadOnlySpan<byte> cStr = "hello\0"u8;
		
		
		try{
			u8* input_c = api.lua_tolstring(L, 1, null);
			IntPtr segment = api.lua_touserdata(L, 2);
			IntPtr env = api.lua_touserdata(L, 3);

			
			
			fixed(u8* str = "log\0"u8){
				api.lua_getglobal(L, str); //全局log入棧
			}
			fixed(u8* s = "warning\0"u8){
				api.lua_getfield(L, -1, s);//stack[-1](即log)入棧。-1潙棧頂
			}
			fixed(u8* str = "殺殺殺殺殺殺殺\0"u8){
				api.lua_pushstring(L, str);//參數1
			}
			svc.MacroFn.lua_call(L, 1, 0); // 1個參數，0個返回值
			str? input = CStr.ToCsStr(input_c);
			if(input == "??"){
				//創建Candidate對象
				api.lua_getglobal(L, "Candidate".CStr());
				api.lua_pushstring(L, "type".CStr());
				api.lua_getfield(L, 2, "_start".CStr());
				api.lua_getfield(L, 2, "_end".CStr());
				api.lua_pushstring(L, "text".CStr());
				api.lua_pushstring(L, "comment".CStr());
				svc.MacroFn.lua_newuserdata(L, 5);
				//調用yield(cand)
				api.lua_getglobal(L, "yield".CStr());
				api.lua_pushvalue(L, -2);
				svc.MacroFn.lua_call(L, 1, 0);
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

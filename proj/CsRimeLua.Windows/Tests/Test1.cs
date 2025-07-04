//dotnet publish -c Release -r win-x64
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsRimeLua.Core.Logger_;
using CsRimeLua.Core.Lua_5_4;
using CsShared.Interop;
using CsShared.Interop.Extn;
using Lua_State = System.IntPtr;
unsafe static class Ext__G{

	//[UnmanagedCallersOnly(EntryPoint = nameof(Test), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 Test(lua_State L){
		var svc= LuaDll.GetLuaSvc();
		var api = svc.Api;
		string? errMsg = null;
		do{
			if(api.lua_type(L, 1) != LuaConsts.LUA_TTABLE){
				errMsg = "api.lua_type(L, 1) != LuaConsts.LUA_TTABLE";
				break;
			}
			var rf = api.luaL_ref(L, svc.Conf.LUA_REGISTRYINDEX);

			api.lua_rawgeti(L, svc.Conf.LUA_REGISTRYINDEX, rf);
			var type = api.lua_getfield(L, -1, "a".CStr());
			if(type == LuaConsts.LUA_TSTRING){
				var cStr = api.lua_tolstring(L, -1, null);
				var str = CStrUtil.ToCsStr(cStr);
				Logger.Log_(str);
			}
			svc.MacroFn.lua_pop(L, 1);
			api.lua_pushstring(L, "csharp".CStr());
		} while (false);
		if(!str.IsNullOrEmpty(errMsg)){
			api.lua_pushstring(L, errMsg.CStr());
		}
		return 1;
	}
}

/* 
do
	local dllPath = "E:/_code/CsRimeLua/src/CsRimeLua.Windows/bin/Release/net9.0/win-x86/publish/CsRimeLua.Windows.dll"
	local fnName = "Test"
	local fn,err = package.loadlib(dllPath,fnName)
	if err then
		Wat(err)
		return
	end
	local myTable = {a="hello"}
	local result = fn(myTable)
	Wat(result)
end

 */


/* 
```c
// 存储表引用
void myFn(lua_State *L) {
    luaL_checktype(L, 1, LUA_TTABLE); // 检查参数是否为表
    int ref = luaL_ref(L, LUA_REGISTRYINDEX);
    myObj->MyTableRef = ref;
}

// 使用表引用
void accessTable(lua_State *L) {
    lua_rawgeti(L, LUA_REGISTRYINDEX, myObj->MyTableRef);
    lua_getfield(L, -1, "d"); // 获取函数字段d
    if (lua_isfunction(L, -1)) {
        lua_pushinteger(L, 10); // 参数a
        lua_pushinteger(L, 20); // 参数b
        lua_call(L, 2, 1);     // 调用d(10,20)
        int result = lua_tointeger(L, -1);
        lua_pop(L, 2);         // 清理栈
    }
}

// 释放引用
void releaseTable(lua_State *L) {
    luaL_unref(L, LUA_REGISTRYINDEX, myObj->MyTableRef);
}
```
 */
namespace CsRimeLua.Core.Lua_5_4;
using CsShared.Interop.Extn;
using System.Runtime.InteropServices;

unsafe public partial class LuaApi{
	public IntPtr DllPtr{get;set;}
	T_Fn _Init<T_Fn>(ref T_Fn Fn, str Name){
		Fn = NativeLibrary.GetExport(DllPtr, Name).AsFn<T_Fn>();
		return Fn;
	}
#pragma warning disable CS8618
	public LuaApi(nint DllPtr){
		var z = this;
		z.DllPtr = DllPtr;
		//z.lua_newstate = NativeLibrary.GetExport(DllPtr, "lua_newstate").AsFn<lua_newstate>();
		//_Init(ref z.lua_absindex, nameof(lua_absindex));


#pragma warning disable CS8601
_Init(ref z.luaL_addgsub, nameof(luaL_addgsub));
_Init(ref z.luaL_addlstring, nameof(luaL_addlstring));
_Init(ref z.luaL_addstring, nameof(luaL_addstring));
_Init(ref z.luaL_addvalue, nameof(luaL_addvalue));
_Init(ref z.luaL_argerror, nameof(luaL_argerror));
_Init(ref z.luaL_buffinit, nameof(luaL_buffinit));
_Init(ref z.luaL_buffinitsize, nameof(luaL_buffinitsize));
_Init(ref z.luaL_callmeta, nameof(luaL_callmeta));
_Init(ref z.luaL_checkany, nameof(luaL_checkany));
_Init(ref z.luaL_checkinteger, nameof(luaL_checkinteger));
_Init(ref z.luaL_checklstring, nameof(luaL_checklstring));
_Init(ref z.luaL_checknumber, nameof(luaL_checknumber));
_Init(ref z.luaL_checkoption, nameof(luaL_checkoption));
_Init(ref z.luaL_checkstack, nameof(luaL_checkstack));
_Init(ref z.luaL_checktype, nameof(luaL_checktype));
_Init(ref z.luaL_checkudata, nameof(luaL_checkudata));
_Init(ref z.luaL_checkversion_, nameof(luaL_checkversion_));
_Init(ref z.luaL_error, nameof(luaL_error));
_Init(ref z.luaL_execresult, nameof(luaL_execresult));
_Init(ref z.luaL_fileresult, nameof(luaL_fileresult));
_Init(ref z.luaL_getmetafield, nameof(luaL_getmetafield));
_Init(ref z.luaL_getsubtable, nameof(luaL_getsubtable));
_Init(ref z.luaL_gsub, nameof(luaL_gsub));
_Init(ref z.luaL_len, nameof(luaL_len));
_Init(ref z.luaL_loadbufferx, nameof(luaL_loadbufferx));
_Init(ref z.luaL_loadfilex, nameof(luaL_loadfilex));
_Init(ref z.luaL_loadstring, nameof(luaL_loadstring));
_Init(ref z.luaL_newmetatable, nameof(luaL_newmetatable));
_Init(ref z.luaL_newstate, nameof(luaL_newstate));
_Init(ref z.luaL_openlibs, nameof(luaL_openlibs));
_Init(ref z.luaL_optinteger, nameof(luaL_optinteger));
_Init(ref z.luaL_optlstring, nameof(luaL_optlstring));
_Init(ref z.luaL_optnumber, nameof(luaL_optnumber));
_Init(ref z.luaL_prepbuffsize, nameof(luaL_prepbuffsize));
_Init(ref z.luaL_pushresult, nameof(luaL_pushresult));
_Init(ref z.luaL_pushresultsize, nameof(luaL_pushresultsize));
_Init(ref z.luaL_ref, nameof(luaL_ref));
_Init(ref z.luaL_requiref, nameof(luaL_requiref));
_Init(ref z.luaL_setfuncs, nameof(luaL_setfuncs));
_Init(ref z.luaL_setmetatable, nameof(luaL_setmetatable));
_Init(ref z.luaL_testudata, nameof(luaL_testudata));
_Init(ref z.luaL_tolstring, nameof(luaL_tolstring));
_Init(ref z.luaL_traceback, nameof(luaL_traceback));
_Init(ref z.luaL_typeerror, nameof(luaL_typeerror));
_Init(ref z.luaL_unref, nameof(luaL_unref));
_Init(ref z.luaL_where, nameof(luaL_where));
_Init(ref z.lua_absindex, nameof(lua_absindex));
_Init(ref z.lua_arith, nameof(lua_arith));
_Init(ref z.lua_atpanic, nameof(lua_atpanic));
_Init(ref z.lua_callk, nameof(lua_callk));
_Init(ref z.lua_checkstack, nameof(lua_checkstack));
_Init(ref z.lua_close, nameof(lua_close));
_Init(ref z.lua_closeslot, nameof(lua_closeslot));
_Init(ref z.lua_compare, nameof(lua_compare));
_Init(ref z.lua_concat, nameof(lua_concat));
_Init(ref z.lua_copy, nameof(lua_copy));
_Init(ref z.lua_createtable, nameof(lua_createtable));
_Init(ref z.lua_dump, nameof(lua_dump));
_Init(ref z.lua_error, nameof(lua_error));
_Init(ref z.lua_gc, nameof(lua_gc));
_Init(ref z.lua_getallocf, nameof(lua_getallocf));
_Init(ref z.lua_getfield, nameof(lua_getfield));
_Init(ref z.lua_getglobal, nameof(lua_getglobal));
_Init(ref z.lua_gethook, nameof(lua_gethook));
_Init(ref z.lua_gethookcount, nameof(lua_gethookcount));
_Init(ref z.lua_gethookmask, nameof(lua_gethookmask));
_Init(ref z.lua_geti, nameof(lua_geti));
_Init(ref z.lua_getinfo, nameof(lua_getinfo));
_Init(ref z.lua_getiuservalue, nameof(lua_getiuservalue));
_Init(ref z.lua_getlocal, nameof(lua_getlocal));
_Init(ref z.lua_getmetatable, nameof(lua_getmetatable));
_Init(ref z.lua_getstack, nameof(lua_getstack));
_Init(ref z.lua_gettable, nameof(lua_gettable));
_Init(ref z.lua_gettop, nameof(lua_gettop));
_Init(ref z.lua_getupvalue, nameof(lua_getupvalue));
_Init(ref z.lua_iscfunction, nameof(lua_iscfunction));
_Init(ref z.lua_isinteger, nameof(lua_isinteger));
_Init(ref z.lua_isnumber, nameof(lua_isnumber));
_Init(ref z.lua_isstring, nameof(lua_isstring));
_Init(ref z.lua_isuserdata, nameof(lua_isuserdata));
_Init(ref z.lua_isyieldable, nameof(lua_isyieldable));
_Init(ref z.lua_len, nameof(lua_len));
_Init(ref z.lua_load, nameof(lua_load));
_Init(ref z.lua_newstate, nameof(lua_newstate));
_Init(ref z.lua_newthread, nameof(lua_newthread));
_Init(ref z.lua_newuserdatauv, nameof(lua_newuserdatauv));
_Init(ref z.lua_next, nameof(lua_next));
_Init(ref z.lua_pcallk, nameof(lua_pcallk));
_Init(ref z.lua_pushboolean, nameof(lua_pushboolean));
_Init(ref z.lua_pushcclosure, nameof(lua_pushcclosure));
_Init(ref z.lua_pushfstring, nameof(lua_pushfstring));
_Init(ref z.lua_pushinteger, nameof(lua_pushinteger));
_Init(ref z.lua_pushlightuserdata, nameof(lua_pushlightuserdata));
_Init(ref z.lua_pushlstring, nameof(lua_pushlstring));
_Init(ref z.lua_pushnil, nameof(lua_pushnil));
_Init(ref z.lua_pushnumber, nameof(lua_pushnumber));
_Init(ref z.lua_pushstring, nameof(lua_pushstring));
_Init(ref z.lua_pushthread, nameof(lua_pushthread));
_Init(ref z.lua_pushvalue, nameof(lua_pushvalue));
_Init(ref z.lua_pushvfstring, nameof(lua_pushvfstring));
_Init(ref z.lua_rawequal, nameof(lua_rawequal));
_Init(ref z.lua_rawget, nameof(lua_rawget));
_Init(ref z.lua_rawgeti, nameof(lua_rawgeti));
_Init(ref z.lua_rawgetp, nameof(lua_rawgetp));
_Init(ref z.lua_rawlen, nameof(lua_rawlen));
_Init(ref z.lua_rawset, nameof(lua_rawset));
_Init(ref z.lua_rawseti, nameof(lua_rawseti));
_Init(ref z.lua_rawsetp, nameof(lua_rawsetp));
_Init(ref z.lua_resetthread, nameof(lua_resetthread));
_Init(ref z.lua_resume, nameof(lua_resume));
_Init(ref z.lua_rotate, nameof(lua_rotate));
_Init(ref z.lua_setallocf, nameof(lua_setallocf));
_Init(ref z.lua_setcstacklimit, nameof(lua_setcstacklimit));
_Init(ref z.lua_setfield, nameof(lua_setfield));
_Init(ref z.lua_setglobal, nameof(lua_setglobal));
_Init(ref z.lua_sethook, nameof(lua_sethook));
_Init(ref z.lua_seti, nameof(lua_seti));
_Init(ref z.lua_setiuservalue, nameof(lua_setiuservalue));
_Init(ref z.lua_setlocal, nameof(lua_setlocal));
_Init(ref z.lua_setmetatable, nameof(lua_setmetatable));
_Init(ref z.lua_settable, nameof(lua_settable));
_Init(ref z.lua_settop, nameof(lua_settop));
_Init(ref z.lua_setupvalue, nameof(lua_setupvalue));
_Init(ref z.lua_setwarnf, nameof(lua_setwarnf));
_Init(ref z.lua_status, nameof(lua_status));
_Init(ref z.lua_stringtonumber, nameof(lua_stringtonumber));
_Init(ref z.lua_toboolean, nameof(lua_toboolean));
_Init(ref z.lua_tocfunction, nameof(lua_tocfunction));
_Init(ref z.lua_toclose, nameof(lua_toclose));
_Init(ref z.lua_tointegerx, nameof(lua_tointegerx));
_Init(ref z.lua_tolstring, nameof(lua_tolstring));
_Init(ref z.lua_tonumberx, nameof(lua_tonumberx));
_Init(ref z.lua_topointer, nameof(lua_topointer));
_Init(ref z.lua_tothread, nameof(lua_tothread));
_Init(ref z.lua_touserdata, nameof(lua_touserdata));
_Init(ref z.lua_type, nameof(lua_type));
_Init(ref z.lua_typename, nameof(lua_typename));
_Init(ref z.lua_upvalueid, nameof(lua_upvalueid));
_Init(ref z.lua_upvaluejoin, nameof(lua_upvaluejoin));
_Init(ref z.lua_version, nameof(lua_version));
_Init(ref z.lua_warning, nameof(lua_warning));
_Init(ref z.lua_xmove, nameof(lua_xmove));
_Init(ref z.lua_yieldk, nameof(lua_yieldk));
_Init(ref z.luaopen_base, nameof(luaopen_base));
_Init(ref z.luaopen_coroutine, nameof(luaopen_coroutine));
_Init(ref z.luaopen_debug, nameof(luaopen_debug));
_Init(ref z.luaopen_io, nameof(luaopen_io));
_Init(ref z.luaopen_math, nameof(luaopen_math));
_Init(ref z.luaopen_os, nameof(luaopen_os));
_Init(ref z.luaopen_package, nameof(luaopen_package));
_Init(ref z.luaopen_string, nameof(luaopen_string));
_Init(ref z.luaopen_table, nameof(luaopen_table));
_Init(ref z.luaopen_utf8, nameof(luaopen_utf8));
#pragma warning restore CS8601
#pragma warning restore CS8618


	}
}
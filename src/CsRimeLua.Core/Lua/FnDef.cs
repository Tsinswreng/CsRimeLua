using System.Runtime.InteropServices;
namespace CsRimeLua.Core.Lua;
#pragma warning disable CS8981

using TODO = Object;
using LuaState = System.IntPtr;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_addgsub(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_addlstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_addstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_addvalue(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_argerror(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_buffinit(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_buffinitsize(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_callmeta(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkany(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkinteger(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checklstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checknumber(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkoption(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkstack(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checktype(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkudata(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkversion_(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_error(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_execresult(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_fileresult(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_getmetafield(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_getsubtable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_gsub(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_len(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_loadbufferx(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_loadfilex(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_loadstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_newmetatable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_newstate(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_openlibs(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_optinteger(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_optlstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_optnumber(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_prepbuffsize(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_pushresult(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_pushresultsize(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_ref(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_requiref(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_setfuncs(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_setmetatable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_testudata(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_tolstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_traceback(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_typeerror(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_unref(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_where(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_absindex(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_arith(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_atpanic(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_callk(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_checkstack(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_close(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_closeslot(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_closethread(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_compare(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_concat(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_copy(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_createtable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_dump(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_error(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gc(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getallocf(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getfield(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getglobal(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gethook(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gethookcount(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gethookmask(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_geti(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getinfo(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getiuservalue(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getlocal(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getmetatable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getstack(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gettable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gettop(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getupvalue(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_iscfunction(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isinteger(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isnumber(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isuserdata(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isyieldable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_len(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_load(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_newstate(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_newthread(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_newuserdatauv(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_next(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pcallk(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushboolean(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushcclosure(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushfstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushinteger(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushlightuserdata(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushlstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushnil(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushnumber(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushthread(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushvalue(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushvfstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawequal(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawget(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawgeti(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawgetp(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawlen(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawset(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawseti(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawsetp(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_resetthread(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_resume(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rotate(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setallocf(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setcstacklimit(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setfield(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setglobal(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_sethook(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_seti(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setiuservalue(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setlocal(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setmetatable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_settable(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_settop(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setupvalue(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setwarnf(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_status(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_stringtonumber(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_toboolean(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tocfunction(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_toclose(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tointegerx(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tolstring(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tonumberx(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_topointer(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tothread(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_touserdata(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_type(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_typename(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_upvalueid(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_upvaluejoin(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_version(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_warning(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_xmove(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_yieldk(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_base(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_coroutine(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_debug(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_io(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_math(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_os(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_package(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_string(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_table(LuaState L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_utf8(LuaState L, TODO x);

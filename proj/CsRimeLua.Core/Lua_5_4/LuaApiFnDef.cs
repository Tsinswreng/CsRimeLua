using System.Runtime.InteropServices;
namespace CsRimeLua.Core.Lua_5_4;
#pragma warning disable CS8981

using TODO = nil;
using lua_State = IntPtr;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_addgsub(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_addlstring(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_addstring(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_addvalue(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_argerror(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_buffinit(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_buffinitsize(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_callmeta(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkany(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkinteger(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 luaL_checklstring(lua_State L, i32 index, UIntPtr* len);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checknumber(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkoption(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkstack(lua_State L, TODO x);

/// <summary>
/// Checks whether the function argument arg has type t. See lua_type for the encoding of types for t.
/// void luaL_checktype (lua_State *L, int arg, int t);
/// </summary>
/// @param t @see LuaConsts
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate void luaL_checktype(lua_State L, i32 arg, i32 t);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkudata(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_checkversion_(lua_State L, TODO x);

/// <summary>
/// int luaL_error (lua_State *L, const char *fmt, ...);
/// Raises an error. The error message format is given by fmt plus any extra arguments, following the same rules of lua_pushfstring. It also adds at the beginning of the message the file name and the line number where the error occurred, if this information is available.

/// This function never returns, but it is an idiom to use it in C functions as return luaL_error(args).
/// </summary>
/// <param name="L"></param>
/// <param name="x"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 luaL_error(lua_State L, u8* fmt);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_execresult(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_fileresult(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_getmetafield(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_getsubtable(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_gsub(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_len(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_loadbufferx(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_loadfilex(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_loadstring(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_newmetatable(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_newstate(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_openlibs(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_optinteger(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_optlstring(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_optnumber(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_prepbuffsize(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_pushresult(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_pushresultsize(lua_State L, TODO x);

/// <summary>
/// int luaL_ref (lua_State *L, int t);
/// Creates and returns a reference, in the table at index t, for the object on the top of the stack (and pops the object).
/// 
/// A reference is a unique integer key. As long as you do not manually add integer keys into the table t, luaL_ref ensures the uniqueness of the key it returns. You can retrieve an object referred by the reference r by calling lua_rawgeti(L, t, r). The function luaL_unref frees a reference.
/// 
/// If the object on the top of the stack is nil, luaL_ref returns the constant LUA_REFNIL. The constant LUA_NOREF is guaranteed to be different from any reference returned by luaL_ref.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 luaL_ref(lua_State L, i32 t);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_requiref(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_setfuncs(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_setmetatable(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_testudata(lua_State L, TODO x);

/// <summary>
/// const char *lua_tolstring (lua_State *L, int index, size_t *len);
/// Converts the Lua value at the given index to a C string. If len is not NULL, it sets *len with the string length. The Lua value must be a string or a number; otherwise, the function returns NULL. If the value is a number, then lua_tolstring also changes the actual value in the stack to a string. (This change confuses lua_next when lua_tolstring is applied to keys during a table traversal.)
/// 
/// lua_tolstring returns a pointer to a string inside the Lua state (see §4.1.3). This string always has a zero ('\0') after its last character (as in C), but can contain other zeros in its body.
/// 
/// This function can raise memory errors only when converting a number to a string (as then it may create a new string).
/// </summary>
/// <param name="L"></param>
/// <param name="x"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate u8* luaL_tolstring(lua_State L, i32 index, size_t* len);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_traceback(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_typeerror(lua_State L, TODO x);
/// <summary>
/// void luaL_unref (lua_State *L, int t, int ref);
/// Releases the reference ref from the table at index t (see luaL_ref). The entry is removed from the table, so that the referred object can be collected. The reference ref is also freed to be used again.
/// 
/// If ref is LUA_NOREF or LUA_REFNIL, luaL_unref does nothing.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate void luaL_unref(lua_State L, i32 t, i32 @ref);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaL_where(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_absindex(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_arith(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_atpanic(lua_State L, TODO x);

/// <summary>
/// void lua_callk (lua_State *L,
///                 int nargs,
///                 int nresults,
///                 lua_KContext ctx,
///                 lua_KFunction k);
/// This function behaves exactly like lua_call, but allows the called function to yield (see §4.5).
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate void lua_callk(
	lua_State L
	,i32 nargs
	,i32 nresults
	,lua_KContext ctx
	,lua_KFunction k
);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_checkstack(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_close(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_closeslot(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_compare(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_concat(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_copy(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_createtable(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_dump(lua_State L, TODO x);

/// <summary>
/// int lua_error (lua_State *L);
/// Raises a Lua error, using the value on the top of the stack as the error object. This function does a long jump, and therefore never returns (see luaL_error).
/// </summary>
/// <param name="L"></param>
/// <param name="x"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_error(lua_State L, TODO x);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gc(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getallocf(lua_State L, TODO x);

/// <summary>
/// int lua_getfield (lua_State *L, int index, const char *k);
/// Pushes onto the stack the value t[k], where t is the value at the given index. As in Lua, this function may trigger a metamethod for the "index" event (see §2.4).
/// 
/// Returns the type of the pushed value.
/// </summary>
/// <param name="L"></param>
/// <param name="x"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_getfield(lua_State L, i32 index, u8* k);

/// <summary>
/// int lua_getglobal (lua_State *L, const char *name);
/// Pushes onto the stack the value of the global name. Returns the type of that value.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_getglobal(lua_State L, u8* name);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gethook(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gethookcount(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gethookmask(lua_State L, TODO x);

/// <summary>
/// int lua_geti (lua_State *L, int index, lua_Integer i);
/// Pushes onto the stack the value t[i], where t is the value at the given index. As in Lua, this function may trigger a metamethod for the "index" event (see §2.4).
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_geti(lua_State L, i32 index, lua_Integer i);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getinfo(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getiuservalue(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getlocal(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getmetatable(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getstack(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gettable(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_gettop(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_getupvalue(lua_State L, TODO x);

/// <summary>
/// int lua_isfunction (lua_State *L, int index);
/// Returns 1 if the value at the given index is a function (either C or Lua), and 0 otherwise.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_iscfunction(lua_State L, i32 index);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isinteger(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isnumber(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isstring(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isuserdata(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_isyieldable(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_len(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_load(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_newstate(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_newthread(lua_State L, TODO x);
/// <summary>
/// void *lua_newuserdatauv (lua_State *L, size_t size, int nuvalue);
/// This function creates and pushes on the stack a new full userdata, with nuvalue associated Lua values, called user values, plus an associated block of raw memory with size bytes. (The user values can be set and read with the functions lua_setiuservalue and lua_getiuservalue.)
/// 
/// The function returns the address of the block of memory. Lua ensures that this address is valid as long as the corresponding userdata is alive (see §2.5). Moreover, if the userdata is marked for finalization (see §2.5.3), its address is valid at least until the call to its finalizer.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate IntPtr lua_newuserdatauv(lua_State L, size_t size, i32 nuvalue);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_next(lua_State L, TODO x);

/// <summary>
/// int lua_pcallk (lua_State *L,
///                 int nargs,
///                 int nresults,
///                 int msgh,
///                 lua_KContext ctx,
///                 lua_KFunction k);
/// This function behaves exactly like lua_pcall, except that it allows the called function to yield (see §4.5).
/// </summary>
/// <param name="L"></param>
/// <param name="x"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_pcallk(
	lua_State L
	,i32 nargs
	,i32 nresults
	,i32 msgh
	,lua_KContext ctx
	,lua_KFunction k
);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushboolean(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushcclosure(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushfstring(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate void lua_pushinteger(lua_State L, i64 n);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushlightuserdata(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushlstring(lua_State L, TODO x);

/// <summary>
/// void lua_pushnil (lua_State *L);
/// Pushes a nil value onto the stack.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate void lua_pushnil(lua_State L);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushnumber(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate void lua_pushstring(lua_State L, u8* s);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushthread(lua_State L, TODO x);
/// <summary>
/// void lua_pushvalue (lua_State *L, int index);
/// Pushes a copy of the element at the given index onto the stack.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate void lua_pushvalue(lua_State L, i32 index);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_pushvfstring(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawequal(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawget(lua_State L, TODO x);
/// <summary>
/// int lua_rawgeti (lua_State *L, int index, lua_Integer n);
/// Pushes onto the stack the value t[n], where t is the table at the given index. The access is raw, that is, it does not use the __index metavalue.
/// 
/// Returns the type of the pushed value.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_rawgeti(lua_State L, i32 index, lua_Integer n);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawgetp(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawlen(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawset(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawseti(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rawsetp(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_resetthread(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_resume(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_rotate(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setallocf(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setcstacklimit(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setfield(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setglobal(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_sethook(lua_State L, TODO x);

/// <summary>
/// void lua_seti (lua_State *L, int index, lua_Integer n);
/// Does the equivalent to t[n] = v, where t is the value at the given index and v is the value on the top of the stack.
/// This function pops the value from the stack. As in Lua, this function may trigger a metamethod for the "newindex" event (see §2.4).
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_seti(lua_State L, i32 index, lua_Integer n);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setiuservalue(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setlocal(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setmetatable(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_settable(lua_State L, TODO x);

/// <summary>
/// void lua_settop (lua_State *L, int index);
/// Accepts any index, or 0, and sets the stack top to this index. If the new top is greater than the old one, then the new elements are filled with nil. If index is 0, then all stack elements are removed.
/// 
/// This function can run arbitrary code when removing an index marked as to-be-closed from the stack.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate void lua_settop(lua_State L, i32 index);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setupvalue(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_setwarnf(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_status(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_stringtonumber(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_toboolean(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tocfunction(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_toclose(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tointegerx(lua_State L, TODO x);

/// <summary>
/// const char *lua_tolstring (lua_State *L, int index, size_t *len);
/// Converts the Lua value at the given index to a C string. If len is not NULL, it sets *len with the string length. The Lua value must be a string or a number; otherwise, the function returns NULL. If the value is a number, then lua_tolstring also changes the actual value in the stack to a string. (This change confuses lua_next when lua_tolstring is applied to keys during a table traversal.)
/// 
/// lua_tolstring returns a pointer to a string inside the Lua state (see §4.1.3). This string always has a zero ('\0') after its last character (as in C), but can contain other zeros in its body.
/// 
/// This function can raise memory errors only when converting a number to a string (as then it may create a new string).
/// #勿手動釋放
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate u8* lua_tolstring(lua_State L, i32 index, size_t* len);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tonumberx(lua_State L, TODO x);

/// <summary>
/// const void *lua_topointer (lua_State *L, int index);
/// Converts the value at the given index to a generic C pointer (void*). The value can be a userdata, a table, a thread, a string, or a function; otherwise, lua_topointer returns NULL. Different objects will give different pointers. There is no way to convert the pointer back to its original value.
/// Typically this function is used only for hashing and debug information.
/// </summary>
/// <param name="L"></param>
/// <param name="x"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate IntPtr lua_topointer(lua_State L, i32 index);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_tothread(lua_State L, TODO x);


/// <summary>
/// void *lua_touserdata (lua_State *L, int index);
/// If the value at the given index is a full userdata, returns its memory-block address. If the value is a light userdata, returns its value (a pointer). Otherwise, returns NULL.
/// </summary>
/// <param name="L"></param>
/// <param name="index"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate IntPtr lua_touserdata(lua_State L, i32 index);

/// <summary>
/// int lua_type (lua_State *L, int index);
/// Returns the type of the value in the given valid index, or LUA_TNONE for a non-valid but acceptable index. The types returned by lua_type are coded by the following constants defined in lua.h: LUA_TNIL, LUA_TNUMBER, LUA_TBOOLEAN, LUA_TSTRING, LUA_TTABLE, LUA_TFUNCTION, LUA_TUSERDATA, LUA_TTHREAD, and LUA_TLIGHTUSERDATA.
/// </summary>
/// <param name="L"></param>
/// <param name="x"></param>
/// <returns></returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate i32 lua_type(lua_State L, i32 index);

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_typename(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_upvalueid(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_upvaluejoin(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_version(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_warning(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_xmove(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO lua_yieldk(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_base(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_coroutine(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_debug(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_io(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_math(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_os(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_package(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_string(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_table(lua_State L, TODO x);
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
unsafe public delegate TODO luaopen_utf8(lua_State L, TODO x);

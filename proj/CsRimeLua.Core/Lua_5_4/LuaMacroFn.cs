namespace CsRimeLua.Core.Lua_5_4;

public partial class LuaMacroFn(LuaApi Lua){
	public LuaApi Api{get;set;} = Lua;
	/// <summary>
	/// #define lua_pop(L,n)		lua_settop(L, -(n)-1)
	/// </summary>
	public void lua_pop(lua_State L, i32 n){
		Api.lua_settop(L, -(n)-1);
	}

/// <summary>
/// void lua_call (lua_State *L, int nargs, int nresults);
/// Calls a function. Like regular Lua calls, lua_call respects the __call metamethod. So, here the word "function" means any callable value.
/// 
/// To do a call you must use the following protocol: first, the function to be called is pushed onto the stack; then, the arguments to the call are pushed in direct order; that is, the first argument is pushed first. Finally you call lua_call; nargs is the number of arguments that you pushed onto the stack. When the function returns, all arguments and the function value are popped and the call results are pushed onto the stack. The number of results is adjusted to nresults, unless nresults is LUA_MULTRET. In this case, all results from the function are pushed; Lua takes care that the returned values fit into the stack space, but it does not ensure any extra space in the stack. The function results are pushed onto the stack in direct order (the first result is pushed first), so that after the call the last result is on the top of the stack.
/// 
/// Any error while calling and running the function is propagated upwards (with a longjmp).
/// 
/// The following example shows how the host program can do the equivalent to this Lua code:
/// 
///      a = f("how", t.x, 14)
/// Here it is in C:
/// 
///      lua_getglobal(L, "f");                  /* function to be called */
///      lua_pushliteral(L, "how");                       /* 1st argument */
///      lua_getglobal(L, "t");                    /* table to be indexed */
///      lua_getfield(L, -1, "x");        /* push result of t.x (2nd arg) */
///      lua_remove(L, -2);                  /* remove 't' from the stack */
///      lua_pushinteger(L, 14);                          /* 3rd argument */
///      lua_call(L, 3, 1);     /* call 'f' with 3 arguments and 1 result */
///      lua_setglobal(L, "a");                         /* set global 'a' */
/// Note that the code above is balanced: at its end, the stack is back to its original configuration. This is considered good programming practice.
/// </summary>
	public void lua_call(lua_State L, i32 n, i32 r){
		Api.lua_callk(L, n, r, 0, null!);
	}

	public IntPtr lua_newuserdata(lua_State L, size_t s){
		return Api.lua_newuserdatauv(L, s, 1);
	}
}
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CsRimeLua.Core;
using CsShared.Interop;
using Lua_State = System.IntPtr;
namespace CsRimeLua.Windows.ClipBoard;

unsafe public partial class Ext_WinClipBoard{
	//[UnmanagedCallersOnly(EntryPoint = nameof(ReadClipBoard_Win), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 ReadClipBoard_Win(lua_State L){
		var Lua = DllLoader.GetLuaApi();
		var text = WinClipBoard.GetText()??"";
		byte* cStr = CStr.ToCStr(text);
		Lua.lua_pushstring(L, cStr);
		Marshal.FreeHGlobal((IntPtr)cStr);
		return 1;
	}

	//[UnmanagedCallersOnly(EntryPoint = nameof(WriteClipBoard_Win), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 WriteClipBoard_Win(lua_State L){
		var Lua = DllLoader.GetLuaApi();
		UIntPtr len = 0;
		var cStr = (u8*)Lua.luaL_checklstring(L, 1, &len);
		if(cStr == null){
			return 0;
		}
		var text = CStr.ToCsStr(cStr);
		if(text != null){
			WinClipBoard.SetText(text);
		}
		return 0;
	}
}

#if false
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Lua_State = System.IntPtr;
using _ = CsRimeLua.Windows.ClipBoard.Ext_WinClipBoard;
class Ext_WinClipBoard{
	[UnmanagedCallersOnly(EntryPoint = nameof(ReadClipBoard_Win), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 ReadClipBoard_Win(Lua_State L){
		return _.ReadClipBoard_Win(L);
	}

	[UnmanagedCallersOnly(EntryPoint = nameof(WriteClipBoard_Win), CallConvs = new[] { typeof(CallConvCdecl) })]
	public static i32 WriteClipBoard_Win(Lua_State L){
		return _.WriteClipBoard_Win(L);
	}
}
#endif
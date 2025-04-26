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
using System.Runtime.InteropServices;
using CsRimeLua.Core.Lua;
using CsShared.Interop;
namespace CsRimeLua.Core;

unsafe public partial class DllLoader{
	public str DllPath{get;set;} ="";

	public nint DllPtr{get;set;}
	public nil Load(){
		DllPtr = NativeLibrary.Load(DllPath);
		if(DllPtr == IntPtr.Zero){
			return null!;
		}

		return null!;
	}


	nil run(){
		
		return null;
	}

	nil l(){
		return null!;
	}


}
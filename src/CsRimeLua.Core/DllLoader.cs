using System.Runtime.InteropServices;

namespace CsRimeLua.Core;

public class DllLoader{
	public str DllPath{get;set;} ="";

	public nint DllPtr{get;set;}
	public nil Load(){
		DllPtr = NativeLibrary.Load(DllPath);
		if(DllPtr == IntPtr.Zero){
			return null!;
		}
		
		return null!;
	}
}
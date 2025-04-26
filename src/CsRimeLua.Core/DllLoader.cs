using System.Runtime.InteropServices;
using CsRimeLua.Core.Lua_5_4;
using CsShared.Interop;
namespace CsRimeLua.Core;

unsafe public partial class DllLoader{
	protected static DllLoader? _Inst = null;
	public static DllLoader Inst => _Inst??= new DllLoader();

	public static LuaFn GetFnPtr(){
		return DllLoader.Inst.Load();
	}

	public str DllPath{get;set;} ="";
	public LuaFn FnPtr{get;set;}
	public nint DllPtr{get;set;}
	public bool IsLoaded{get;protected set;}=false;
	public LuaFn Load(){
		if(IsLoaded){
			return FnPtr;
		}
		DllPtr = NativeLibrary.Load(DllPath);
		if(DllPtr == IntPtr.Zero){
			//TODO
			throw new Exception("Failed to load dll");
		}
		FnPtr = new LuaFn(DllPtr);
		IsLoaded = true;
		return FnPtr;
	}

}
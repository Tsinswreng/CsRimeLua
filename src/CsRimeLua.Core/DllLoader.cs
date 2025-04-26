using System.Runtime.InteropServices;
using CsRimeLua.Core.Consts;
using CsRimeLua.Core.Logger_;
using CsRimeLua.Core.Lua_5_4;
using CsShared.Interop;
namespace CsRimeLua.Core;

unsafe public partial class DllLoader{
	protected static DllLoader? _Inst = null;
	public static DllLoader Inst => _Inst??= new DllLoader();

	public DllLoader(){
		Logger.Inst.Log("DllPathFromEnv: "+DllPath);
		DllPath = "D:/ENV/Rime/weasel-0.15.0/rime.dll"; //TODO temp test
	}

	public static LuaApi GetLuaApi(){
		return DllLoader.Inst.Load();
	}

	public str DllPath{get;set;} = Environment.GetEnvironmentVariable(EnvVar.DLL_PATH)??"";
	public LuaApi FnPtr{get;set;}
	public nint DllPtr{get;set;}
	public bool IsLoaded{get;protected set;}=false;
	static nil Log(str Msg){
		return Logger.Inst.Log(Msg);
	}
	public LuaApi Load(){
		if(IsLoaded){
			return FnPtr;
		}
		try{
			DllPtr = NativeLibrary.Load(DllPath);
			if(DllPtr == IntPtr.Zero){
				throw new Exception("Failed to load dll");
			}
			FnPtr = new LuaApi(DllPtr);
			IsLoaded = true;
			return FnPtr;
		}
		catch (System.Exception e){
			Log(e.ToString());
			throw;
		}
	}

}
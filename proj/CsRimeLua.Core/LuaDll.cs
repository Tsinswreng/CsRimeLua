using System.Reflection;
using System.Runtime.InteropServices;
using CsRimeLua.Core.Consts;
using CsRimeLua.Core.Logger_;
using CsRimeLua.Core.Lua_5_4;
using CsShared.Interop;
namespace CsRimeLua.Core;

unsafe public partial class LuaDll{
	protected static LuaDll? _Inst = null;
	public static LuaDll Inst => _Inst??= new LuaDll();

	public LuaDll(){
		// //Logger.Inst.Log("Assembly.GetExecutingAssembly().Location: "+Assembly.GetExecutingAssembly().Location); //無
		// Logger.Log_("System.AppContext.BaseDirectory: "+System.AppContext.BaseDirectory); // D:\ENV\Rime\weasel-0.15.0\
		// DllPath = "D:/ENV/Rime/weasel-0.15.0/rime.dll"; //TODO temp test
		Logger.Log_(">LuaDll.ctor");
		DllPath = "rime";
		Logger.Log_("<LuaDll.ctor");
	}
	
	public static LuaApi GetLuaApi(){
		var inst = LuaDll.Inst;
		inst.Load();
		return inst.LuaApi;
	}
	public static LuaSvc GetLuaSvc(){
		var inst = LuaDll.Inst;
		inst.Load();
		return inst.LuaSvc;
	}

	public str DllPath{get;set;} = Environment.GetEnvironmentVariable(EnvVar.DLL_PATH)??"";
	public LuaApi LuaApi{get;set;}
	public LuaSvc LuaSvc{get;set;}
	public nint DllPtr{get;set;}
	public bool IsLoaded{get;protected set;}=false;
	static nil Log(str Msg){
		return Logger.Inst.Log(Msg);
	}
	public nil Load(){
		if(IsLoaded){
			return null!;
		}
		Log("Init Load");
		try{
			DllPtr = NativeLibrary.Load(DllPath);
			if(DllPtr == IntPtr.Zero){
				throw new Exception("Failed to load dll");
			}
			LuaApi = new LuaApi(DllPtr);
			LuaSvc = new LuaSvc(LuaApi);
			IsLoaded = true;
			return null!;
		}
		catch (System.Exception e){
			Log(e.ToString());
			throw;
		}
	}

}
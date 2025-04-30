using System.Text;
using CsShared.Interop;

namespace CsRimeLua.Core.Str;


unsafe public class CStrCache{

	protected static CStrCache? _Inst = null;
	public static CStrCache Inst => _Inst??= new CStrCache();

	Dictionary<str, IntPtr> CsStr_CStr = new Dictionary<str, IntPtr>();
	Dictionary<IntPtr, str> CStr_CsStr = new Dictionary<IntPtr, str>();

	public IntPtr GetCStr(str CsStr){
		if(CsStr_CStr.ContainsKey(CsStr)){
			return CsStr_CStr[CsStr];
		}
		
		var cStr = (IntPtr)CsStr.CStr();
		CsStr_CStr[CsStr] = cStr;
		return cStr;
	}

	public str? GetCsStr(u8* cStr){
		if(cStr == null){
			return null;
		}
		var intPtr = (IntPtr)cStr;
		if(CStr_CsStr.ContainsKey(intPtr)){
			return CStr_CsStr[intPtr];
		}
		var CsStr = CStr.ToCsStr(cStr);
		CStr_CsStr[intPtr] = CsStr!;
		return CsStr;
	}
}

unsafe public static class Extn_CStrCache{
	public static CStrCache CStrCache{get;} = CStrCache.Inst;
	public static str? CsStr(u8* cStr){
		return CStrCache.GetCsStr(cStr);
	}
	public static IntPtr CStr(this str CsStr){
		return CStrCache.GetCStr(CsStr);
	}
}
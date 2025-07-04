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
		var cStr = (IntPtr)CStrUtil.ToCStr(CsStr);
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
		var CsStr = CStrUtil.ToCsStr(cStr);
		CStr_CsStr[intPtr] = CsStr!;
		return CsStr;
	}

	public void Delete(str CsStr){
		if(!CsStr_CStr.ContainsKey(CsStr)){
			return;
		}
		var cStr = (u8*)CsStr_CStr[CsStr];
		PtrUtil.FreeEtNull(ref cStr);
		CsStr_CStr.Remove(CsStr);
	}
}

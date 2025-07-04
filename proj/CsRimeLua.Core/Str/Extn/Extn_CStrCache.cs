namespace CsRimeLua.Core.Str.Extn;
unsafe public static class Extn_CStrCache{
	public static CStrCache CStrCache{get;} = CStrCache.Inst;
	public static str? CsStr(u8* cStr){
		return CStrCache.GetCsStr(cStr);
	}
	public static u8* CStr(this str CsStr){
		return (u8*)CStrCache.GetCStr(CsStr);
	}
}
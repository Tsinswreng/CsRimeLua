namespace CsShared.Interop;
unsafe public static class Extn_CStr {
	public static byte* cStr(this string? z){
		return CStrUtil.CsStrToCStr(z);
	}
}
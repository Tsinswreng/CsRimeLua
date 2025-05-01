namespace CsShared.Interop.Extn;
unsafe public static class Extn_CStr {
	public static byte* CStr(this string? z){
		return Interop.CStrUtil.ToCStr(z);
	}
}
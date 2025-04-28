namespace CsShared.Interop;
unsafe public static class Extn_CStr {
	public static byte* CStr(this string? z){
		return Interop.CStr.ToCStr(z);
	}
}
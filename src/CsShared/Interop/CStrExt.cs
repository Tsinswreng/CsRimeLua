namespace CsShared.Interop;
unsafe public static class CStrExt {
	public static byte* cStr(this string? z){
		return CStrUtil.csStrToCStr(z);
	}
}
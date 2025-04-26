using System.Runtime.InteropServices;
namespace CsShared.Interop;
public static class FnPtrExt{
	public static TDelegate asFn<TDelegate>(this nint z){
		if(z == nint.Zero){
			return default;
		}
		return Marshal.GetDelegateForFunctionPointer<TDelegate>(z);
	}
}
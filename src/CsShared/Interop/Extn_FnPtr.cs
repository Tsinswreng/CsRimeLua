using System.Runtime.InteropServices;
namespace CsShared.Interop;
public static class Extn_FnPtr{
	public static TDelegate AsFn<TDelegate>(this IntPtr z){
		if(z == IntPtr.Zero){
			return default!;
		}
		return Marshal.GetDelegateForFunctionPointer<TDelegate>(z);
	}
}
using System.Runtime.InteropServices;
namespace CsShared.Interop.Extn;
public static class Extn_FnPtr{
	public static TDelegate AsFn<TDelegate>(this nint z){
		if(z == nint.Zero){
			return default!;
		}
		return Marshal.GetDelegateForFunctionPointer<TDelegate>(z);
	}
}
using static System.Runtime.InteropServices.NativeMemory;
using static System.Runtime.InteropServices.Marshal;
namespace CsShared.Interop;
unsafe public static class PtrUtil{
	public static T* New<T>()where T:unmanaged{
		return (T*)AllocZeroed((nuint)SizeOf<T>());
	}

	public static nil FreeEtNull<T>(ref T* ptrRef)where T:unmanaged{
		if(ptrRef == null){
			return null!;
		}
		Free(ptrRef);
		ptrRef = null;
		return null!;
	}


	// public static zero FreeIfNotNull<T>(T* ptr)where T:unmanaged{
	// 	if(ptr != null){
	// 		Free(ptr);
	// 	}
	// 	return 0;
	// }

	///
	/// int* ptr = xxx
	/// FreeEtNull(&ptr)
	/// sometimes needs to use fixed{}
	///
	// public static zero FreeEtNull<T>(T** ptr2d)where T:unmanaged{
	// 	var ptr = *ptr2d;
	// 	if(ptr == null){
	// 		return 0;
	// 	}
	// 	Free(ptr);
	// 	*ptr2d = null;
	// 	return 0;
	// }

	
	public static int SizeOf_int<T>()where T:unmanaged{
		return SizeOf<T>();
	}
}
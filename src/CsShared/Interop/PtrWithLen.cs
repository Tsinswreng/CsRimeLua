namespace CsShared.Interop;
unsafe public struct PtrWithLen<T> where T : unmanaged{
	public u64 Length;
	public T* Ptr;
}
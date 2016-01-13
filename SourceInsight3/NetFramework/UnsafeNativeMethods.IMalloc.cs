public interface IMalloc
{

	// Methods
	public abstract virtual System.IntPtr Alloc(int cb) {}
	public abstract virtual System.IntPtr Realloc(System.IntPtr pv, int cb) {}
	public abstract virtual void Free(System.IntPtr pv) {}
	public abstract virtual int GetSize(System.IntPtr pv) {}
	public abstract virtual int DidAlloc(System.IntPtr pv) {}
	public abstract virtual void HeapMinimize() {}
}


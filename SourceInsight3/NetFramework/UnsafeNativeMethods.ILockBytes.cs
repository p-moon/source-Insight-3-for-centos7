public interface ILockBytes
{

	// Methods
	public abstract virtual void ReadAt(long ulOffsetout , System.IntPtr pv, int cbout , int[] pcbRead) {}
	public abstract virtual void WriteAt(long ulOffset, System.IntPtr pv, int cbout , int[] pcbWritten) {}
	public abstract virtual void Flush() {}
	public abstract virtual void SetSize(long cb) {}
	public abstract virtual void LockRegion(long libOffset, long cb, int dwLockType) {}
	public abstract virtual void UnlockRegion(long libOffset, long cb, int dwLockType) {}
	public abstract virtual void Stat(out STATSTG pstatstg, int grfStatFlag) {}
}


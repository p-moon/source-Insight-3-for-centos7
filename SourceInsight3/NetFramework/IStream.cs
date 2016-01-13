public interface IStream
{

	// Methods
	public abstract virtual void Read(out byte[] pv, int cb, System.IntPtr pcbRead) {}
	public abstract virtual void Write(byte[] pv, int cb, System.IntPtr pcbWritten) {}
	public abstract virtual void Seek(long dlibMove, int dwOrigin, System.IntPtr plibNewPosition) {}
	public abstract virtual void SetSize(long libNewSize) {}
	public abstract virtual void CopyTo(IStream pstm, long cb, System.IntPtr pcbRead, System.IntPtr pcbWritten) {}
	public abstract virtual void Commit(int grfCommitFlags) {}
	public abstract virtual void Revert() {}
	public abstract virtual void LockRegion(long libOffset, long cb, int dwLockType) {}
	public abstract virtual void UnlockRegion(long libOffset, long cb, int dwLockType) {}
	public abstract virtual void Stat(out STATSTG& pstatstg, int grfStatFlag) {}
	public abstract virtual void Clone(out IStream& ppstm) {}
}


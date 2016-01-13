public interface IStream
{

	// Methods
	public abstract virtual int Read(System.IntPtr buf, int len) {}
	public abstract virtual int Write(System.IntPtr buf, int len) {}
	public abstract virtual long Seek(long dlibMove, int dwOrigin) {}
	public abstract virtual void SetSize(long libNewSize) {}
	public abstract virtual long CopyTo(IStream pstm, long cbout , long[] pcbRead) {}
	public abstract virtual void Commit(int grfCommitFlags) {}
	public abstract virtual void Revert() {}
	public abstract virtual void LockRegion(long libOffset, long cb, int dwLockType) {}
	public abstract virtual void UnlockRegion(long libOffset, long cb, int dwLockType) {}
	public abstract virtual void Stat(System.IntPtr pStatstg, int grfStatFlag) {}
	public abstract virtual IStream Clone() {}
}


public class ComStreamFromDataStream : IStream
{

	// Constructors
	public ComStreamFromDataStream(System.IO.Stream dataStream) {}

	// Methods
	public virtual IStream Clone() {}
	public virtual void Commit(int grfCommitFlags) {}
	public virtual long CopyTo(IStream pstm, long cb, long[] pcbRead) {}
	public System.IO.Stream GetDataStream() {}
	public virtual void LockRegion(long libOffset, long cb, int dwLockType) {}
	public virtual int Read(System.IntPtr buf, int length) {}
	public int Read(byte[] buffer, int length) {}
	public virtual void Revert() {}
	public virtual long Seek(long offset, int origin) {}
	public virtual void SetSize(long value) {}
	public virtual void Stat(STATSTG pstatstg, int grfStatFlag) {}
	public virtual void UnlockRegion(long libOffset, long cb, int dwLockType) {}
	public virtual int Write(System.IntPtr buf, int length) {}
	public int Write(byte[] buffer, int length) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


public class OracleBFile : System.IO.Stream, System.IDisposable, System.ICloneable, System.Data.SqlTypes.INullable
{

	// Methods
	public virtual object Clone() {}
	public long CopyTo(OracleLob destination) {}
	public long CopyTo(OracleLob destination, long destinationOffset) {}
	public long CopyTo(long sourceOffset, OracleLob destination, long destinationOffset, long amount) {}
	public virtual void Flush() {}
	public virtual int Read(byte[] buffer, int offset, int count) {}
	public virtual long Seek(long offset, System.IO.SeekOrigin origin) {}
	public void SetFileName(string directory, string file) {}
	public virtual void SetLength(long value) {}
	public virtual void Write(byte[] buffer, int offset, int count) {}
	public virtual void Close() {}
	public virtual void Dispose() {}
	public virtual System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) {}
	public virtual int EndRead(System.IAsyncResult asyncResult) {}
	public virtual System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) {}
	public virtual void EndWrite(System.IAsyncResult asyncResult) {}
	public virtual int ReadByte() {}
	public virtual void WriteByte(byte value) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public OracleBFile Null;

	// Properties
	public bool CanRead { get{} }
	public bool CanSeek { get{} }
	public bool CanWrite { get{} }
	public OracleConnection Connection { get{} }
	public string DirectoryName { get{} }
	public bool FileExists { get{} }
	public string FileName { get{} }
	public bool IsNull { get{} }
	public long Length { get{} }
	public long Position { get{} set{} }
	public object Value { get{} }
	public bool CanTimeout { get{} }
	public int ReadTimeout { get{} set{} }
	public int WriteTimeout { get{} set{} }
}


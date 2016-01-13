public class GZipStream : System.IO.Stream, System.IDisposable
{

	// Constructors
	public GZipStream(System.IO.Stream stream, CompressionMode mode) {}
	public GZipStream(System.IO.Stream stream, CompressionMode mode, bool leaveOpen) {}

	// Methods
	public virtual void Flush() {}
	public virtual long Seek(long offset, System.IO.SeekOrigin origin) {}
	public virtual void SetLength(long value) {}
	public virtual System.IAsyncResult BeginRead(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual int EndRead(System.IAsyncResult asyncResult) {}
	public virtual System.IAsyncResult BeginWrite(byte[] array, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual void EndWrite(System.IAsyncResult asyncResult) {}
	public virtual int Read(byte[] array, int offset, int count) {}
	public virtual void Write(byte[] array, int offset, int count) {}
	public virtual void Close() {}
	public virtual void Dispose() {}
	public virtual int ReadByte() {}
	public virtual void WriteByte(byte value) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CanRead { get{} }
	public bool CanWrite { get{} }
	public bool CanSeek { get{} }
	public long Length { get{} }
	public long Position { get{} set{} }
	public System.IO.Stream BaseStream { get{} }
	public bool CanTimeout { get{} }
	public int ReadTimeout { get{} set{} }
	public int WriteTimeout { get{} set{} }
}


public class Stream : System.MarshalByRefObject, System.IDisposable
{

	// Methods
	public virtual void Close() {}
	public virtual void Dispose() {}
	public abstract virtual void Flush() {}
	public virtual System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) {}
	public virtual int EndRead(System.IAsyncResult asyncResult) {}
	public virtual System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) {}
	public virtual void EndWrite(System.IAsyncResult asyncResult) {}
	public abstract virtual long Seek(long offset, SeekOrigin origin) {}
	public abstract virtual void SetLength(long value) {}
	public abstract virtual int Read(out byte[] buffer, int offset, int count) {}
	public virtual int ReadByte() {}
	public abstract virtual void Write(byte[] buffer, int offset, int count) {}
	public virtual void WriteByte(byte value) {}
	public static Stream Synchronized(Stream stream) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public Stream Null;

	// Properties
	public bool CanRead { get{} }
	public bool CanSeek { get{} }
	public bool CanTimeout { get{} }
	public bool CanWrite { get{} }
	public long Length { get{} }
	public long Position { get{} set{} }
	public int ReadTimeout { get{} set{} }
	public int WriteTimeout { get{} set{} }
}


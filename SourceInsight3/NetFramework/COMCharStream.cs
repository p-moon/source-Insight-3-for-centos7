public class COMCharStream : System.IO.Stream, System.IDisposable
{

	// Constructors
	public COMCharStream(IMessageReceiver messageReceiver) {}

	// Methods
	public virtual void Close() {}
	public virtual void Flush() {}
	public virtual int Read(byte[] buffer, int offset, int count) {}
	public virtual long Seek(long offset, System.IO.SeekOrigin origin) {}
	public virtual void SetLength(long value) {}
	public virtual void Write(byte[] buffer, int offset, int count) {}
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

	// Properties
	public bool CanWrite { get{} }
	public bool CanRead { get{} }
	public bool CanSeek { get{} }
	public long Length { get{} }
	public long Position { get{} set{} }
	public bool CanTimeout { get{} }
	public int ReadTimeout { get{} set{} }
	public int WriteTimeout { get{} set{} }
}


public class NetworkStream : System.IO.Stream, System.IDisposable
{

	// Constructors
	public NetworkStream(Socket socket) {}
	public NetworkStream(Socket socket, bool ownsSocket) {}
	public NetworkStream(Socket socket, System.IO.FileAccess access) {}
	public NetworkStream(Socket socket, System.IO.FileAccess access, bool ownsSocket) {}

	// Methods
	public virtual long Seek(long offset, System.IO.SeekOrigin origin) {}
	public virtual int Read(out byte[] buffer, int offset, int size) {}
	public virtual void Write(byte[] buffer, int offset, int size) {}
	public void Close(int timeout) {}
	public virtual System.IAsyncResult BeginRead(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state) {}
	public virtual int EndRead(System.IAsyncResult asyncResult) {}
	public virtual System.IAsyncResult BeginWrite(byte[] buffer, int offset, int size, System.AsyncCallback callback, object state) {}
	public virtual void EndWrite(System.IAsyncResult asyncResult) {}
	public virtual void Flush() {}
	public virtual void SetLength(long value) {}
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
	public bool CanSeek { get{} }
	public bool CanWrite { get{} }
	public bool CanTimeout { get{} }
	public int ReadTimeout { get{} set{} }
	public int WriteTimeout { get{} set{} }
	public bool DataAvailable { get{} }
	public long Length { get{} }
	public long Position { get{} set{} }
}


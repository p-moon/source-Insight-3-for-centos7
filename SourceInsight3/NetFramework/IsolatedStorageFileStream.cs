public class IsolatedStorageFileStream : System.IO.FileStream, System.IDisposable
{

	// Constructors
	public IsolatedStorageFileStream(string path, System.IO.FileMode mode) {}
	public IsolatedStorageFileStream(string path, System.IO.FileMode mode, IsolatedStorageFile isf) {}
	public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access) {}
	public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, IsolatedStorageFile isf) {}
	public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share) {}
	public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, IsolatedStorageFile isf) {}
	public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize) {}
	public IsolatedStorageFileStream(string path, System.IO.FileMode mode, System.IO.FileAccess access, System.IO.FileShare share, int bufferSize, IsolatedStorageFile isf) {}

	// Methods
	public virtual void Flush() {}
	public virtual void SetLength(long value) {}
	public virtual int Read(byte[] buffer, int offset, int count) {}
	public virtual int ReadByte() {}
	public virtual long Seek(long offset, System.IO.SeekOrigin origin) {}
	public virtual void Write(byte[] buffer, int offset, int count) {}
	public virtual void WriteByte(byte value) {}
	public virtual System.IAsyncResult BeginRead(byte[] buffer, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject) {}
	public virtual int EndRead(System.IAsyncResult asyncResult) {}
	public virtual System.IAsyncResult BeginWrite(byte[] buffer, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject) {}
	public virtual void EndWrite(System.IAsyncResult asyncResult) {}
	public System.Security.AccessControl.FileSecurity GetAccessControl() {}
	public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity) {}
	public virtual void Lock(long position, long length) {}
	public virtual void Unlock(long position, long length) {}
	public virtual void Close() {}
	public virtual void Dispose() {}
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
	public bool IsAsync { get{} }
	public long Length { get{} }
	public long Position { get{} set{} }
	public System.IntPtr Handle { get{} }
	public Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle { get{} }
	public string Name { get{} }
	public bool CanTimeout { get{} }
	public int ReadTimeout { get{} set{} }
	public int WriteTimeout { get{} set{} }
}


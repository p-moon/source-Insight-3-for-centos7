public class FileStream : Stream, System.IDisposable
{

	// Constructors
	public FileStream(string path, FileMode mode) {}
	public FileStream(string path, FileMode mode, FileAccess access) {}
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share) {}
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) {}
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) {}
	public FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) {}
	public FileStream(string path, FileMode mode, System.Security.AccessControl.FileSystemRights rights, FileShare share, int bufferSize, FileOptions options, System.Security.AccessControl.FileSecurity fileSecurity) {}
	public FileStream(string path, FileMode mode, System.Security.AccessControl.FileSystemRights rights, FileShare share, int bufferSize, FileOptions options) {}
	public FileStream(System.IntPtr handle, FileAccess access) {}
	public FileStream(System.IntPtr handle, FileAccess access, bool ownsHandle) {}
	public FileStream(System.IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize) {}
	public FileStream(System.IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync) {}
	public FileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, FileAccess access) {}
	public FileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, FileAccess access, int bufferSize) {}
	public FileStream(Microsoft.Win32.SafeHandles.SafeFileHandle handle, FileAccess access, int bufferSize, bool isAsync) {}

	// Methods
	public System.Security.AccessControl.FileSecurity GetAccessControl() {}
	public void SetAccessControl(System.Security.AccessControl.FileSecurity fileSecurity) {}
	public virtual void Flush() {}
	public virtual void SetLength(long value) {}
	public virtual int Read(out byte[] array, int offset, int count) {}
	public virtual long Seek(long offset, SeekOrigin origin) {}
	public virtual void Write(byte[] array, int offset, int count) {}
	public virtual System.IAsyncResult BeginRead(byte[] array, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject) {}
	public virtual int EndRead(System.IAsyncResult asyncResult) {}
	public virtual int ReadByte() {}
	public virtual System.IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, System.AsyncCallback userCallback, object stateObject) {}
	public virtual void EndWrite(System.IAsyncResult asyncResult) {}
	public virtual void WriteByte(byte value) {}
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
	public string Name { get{} }
	public long Position { get{} set{} }
	public System.IntPtr Handle { get{} }
	public Microsoft.Win32.SafeHandles.SafeFileHandle SafeFileHandle { get{} }
	public bool CanTimeout { get{} }
	public int ReadTimeout { get{} set{} }
	public int WriteTimeout { get{} set{} }
}


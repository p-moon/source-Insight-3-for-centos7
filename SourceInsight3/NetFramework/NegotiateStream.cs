public class NegotiateStream : AuthenticatedStream, System.IDisposable
{

	// Constructors
	public NegotiateStream(System.IO.Stream innerStream) {}
	public NegotiateStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) {}

	// Methods
	public virtual void AuthenticateAsClient() {}
	public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, string targetName) {}
	public virtual void AuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel) {}
	public virtual System.IAsyncResult BeginAuthenticateAsClient(System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual System.IAsyncResult BeginAuthenticateAsClient(System.Net.NetworkCredential credential, string targetName, ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel allowedImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual void EndAuthenticateAsClient(System.IAsyncResult asyncResult) {}
	public virtual void AuthenticateAsServer() {}
	public virtual void AuthenticateAsServer(System.Net.NetworkCredential credential, ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel) {}
	public virtual System.IAsyncResult BeginAuthenticateAsServer(System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Net.NetworkCredential credential, ProtectionLevel requiredProtectionLevel, System.Security.Principal.TokenImpersonationLevel requiredImpersonationLevel, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual void EndAuthenticateAsServer(System.IAsyncResult asyncResult) {}
	public virtual void SetLength(long value) {}
	public virtual long Seek(long offset, System.IO.SeekOrigin origin) {}
	public virtual void Flush() {}
	public virtual int Read(byte[] buffer, int offset, int count) {}
	public virtual void Write(byte[] buffer, int offset, int count) {}
	public virtual System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual int EndRead(System.IAsyncResult asyncResult) {}
	public virtual System.IAsyncResult BeginWrite(byte[] buffer, int offset, int count, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual void EndWrite(System.IAsyncResult asyncResult) {}
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
	public bool IsAuthenticated { get{} }
	public bool IsMutuallyAuthenticated { get{} }
	public bool IsEncrypted { get{} }
	public bool IsSigned { get{} }
	public bool IsServer { get{} }
	public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get{} }
	public System.Security.Principal.IIdentity RemoteIdentity { get{} }
	public bool CanSeek { get{} }
	public bool CanRead { get{} }
	public bool CanTimeout { get{} }
	public bool CanWrite { get{} }
	public int ReadTimeout { get{} set{} }
	public int WriteTimeout { get{} set{} }
	public long Length { get{} }
	public long Position { get{} set{} }
	public bool LeaveInnerStreamOpen { get{} }
}


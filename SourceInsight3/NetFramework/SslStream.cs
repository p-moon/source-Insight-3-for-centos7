public class SslStream : AuthenticatedStream, System.IDisposable
{

	// Constructors
	public SslStream(System.IO.Stream innerStream) {}
	public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen) {}
	public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) {}
	public SslStream(System.IO.Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) {}

	// Methods
	public virtual void AuthenticateAsClient(string targetHost) {}
	public virtual void AuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) {}
	public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual System.IAsyncResult BeginAuthenticateAsClient(string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual void EndAuthenticateAsClient(System.IAsyncResult asyncResult) {}
	public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) {}
	public virtual void AuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation) {}
	public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual System.IAsyncResult BeginAuthenticateAsServer(System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, System.Security.Authentication.SslProtocols enabledSslProtocols, bool checkCertificateRevocation, System.AsyncCallback asyncCallback, object asyncState) {}
	public virtual void EndAuthenticateAsServer(System.IAsyncResult asyncResult) {}
	public virtual void SetLength(long value) {}
	public virtual long Seek(long offset, System.IO.SeekOrigin origin) {}
	public virtual void Flush() {}
	public virtual int Read(byte[] buffer, int offset, int count) {}
	public void Write(byte[] buffer) {}
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
	public System.Security.Authentication.SslProtocols SslProtocol { get{} }
	public bool CheckCertRevocationStatus { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate LocalCertificate { get{} }
	public System.Security.Cryptography.X509Certificates.X509Certificate RemoteCertificate { get{} }
	public System.Security.Authentication.CipherAlgorithmType CipherAlgorithm { get{} }
	public int CipherStrength { get{} }
	public System.Security.Authentication.HashAlgorithmType HashAlgorithm { get{} }
	public int HashStrength { get{} }
	public System.Security.Authentication.ExchangeAlgorithmType KeyExchangeAlgorithm { get{} }
	public int KeyExchangeStrength { get{} }
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


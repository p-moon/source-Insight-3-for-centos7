public class SimpleWorkerRequest : System.Web.HttpWorkerRequest
{

	// Constructors
	public SimpleWorkerRequest(string page, string query, System.IO.TextWriter output) {}
	public SimpleWorkerRequest(string appVirtualDir, string appPhysicalDir, string page, string query, System.IO.TextWriter output) {}

	// Methods
	public virtual string GetUriPath() {}
	public virtual string GetQueryString() {}
	public virtual string GetRawUrl() {}
	public virtual string GetHttpVerbName() {}
	public virtual string GetHttpVersion() {}
	public virtual string GetRemoteAddress() {}
	public virtual int GetRemotePort() {}
	public virtual string GetLocalAddress() {}
	public virtual int GetLocalPort() {}
	public virtual System.IntPtr GetUserToken() {}
	public virtual string GetFilePath() {}
	public virtual string GetFilePathTranslated() {}
	public virtual string GetPathInfo() {}
	public virtual string GetAppPath() {}
	public virtual string GetAppPathTranslated() {}
	public virtual string GetServerVariable(string name) {}
	public virtual string MapPath(string path) {}
	public virtual void SendStatus(int statusCode, string statusDescription) {}
	public virtual void SendKnownResponseHeader(int index, string value) {}
	public virtual void SendUnknownResponseHeader(string name, string value) {}
	public virtual void SendResponseFromMemory(byte[] data, int length) {}
	public virtual void SendResponseFromFile(string filename, long offset, long length) {}
	public virtual void SendResponseFromFile(System.IntPtr handle, long offset, long length) {}
	public virtual void FlushResponse(bool finalFlush) {}
	public virtual void EndOfRequest() {}
	public virtual byte[] GetQueryStringRawBytes() {}
	public virtual string GetRemoteName() {}
	public virtual string GetServerName() {}
	public virtual long GetConnectionID() {}
	public virtual long GetUrlContextID() {}
	public virtual string GetAppPoolID() {}
	public virtual int GetRequestReason() {}
	public virtual System.IntPtr GetVirtualPathToken() {}
	public virtual bool IsSecure() {}
	public virtual string GetProtocol() {}
	public virtual int GetPreloadedEntityBodyLength() {}
	public virtual int GetPreloadedEntityBody(byte[] buffer, int offset) {}
	public virtual byte[] GetPreloadedEntityBody() {}
	public virtual bool IsEntireEntityBodyIsPreloaded() {}
	public virtual int GetTotalEntityBodyLength() {}
	public virtual int ReadEntityBody(byte[] buffer, int size) {}
	public virtual int ReadEntityBody(byte[] buffer, int offset, int size) {}
	public virtual string GetKnownRequestHeader(int index) {}
	public virtual string GetUnknownRequestHeader(string name) {}
	public virtual string[][] GetUnknownRequestHeaders() {}
	public virtual long GetBytesRead() {}
	public virtual void SendResponseFromMemory(System.IntPtr data, int length) {}
	public virtual void SetEndOfSendNotification(System.Web.HttpWorkerRequest.EndOfSendNotification callback, object extraData) {}
	public virtual void SendCalculatedContentLength(int contentLength) {}
	public virtual void SendCalculatedContentLength(long contentLength) {}
	public virtual bool HeadersSent() {}
	public virtual bool IsClientConnected() {}
	public virtual void CloseConnection() {}
	public virtual byte[] GetClientCertificate() {}
	public virtual System.DateTime GetClientCertificateValidFrom() {}
	public virtual System.DateTime GetClientCertificateValidUntil() {}
	public virtual byte[] GetClientCertificateBinaryIssuer() {}
	public virtual int GetClientCertificateEncoding() {}
	public virtual byte[] GetClientCertificatePublicKey() {}
	public bool HasEntityBody() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MachineConfigPath { get{} }
	public string RootWebConfigPath { get{} }
	public string MachineInstallDirectory { get{} }
	public System.Guid RequestTraceIdentifier { get{} }
}


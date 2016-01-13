public class HttpWorkerRequest
{

	// Methods
	public abstract virtual string GetUriPath() {}
	public abstract virtual string GetQueryString() {}
	public abstract virtual string GetRawUrl() {}
	public abstract virtual string GetHttpVerbName() {}
	public abstract virtual string GetHttpVersion() {}
	public abstract virtual string GetRemoteAddress() {}
	public abstract virtual int GetRemotePort() {}
	public abstract virtual string GetLocalAddress() {}
	public abstract virtual int GetLocalPort() {}
	public virtual byte[] GetQueryStringRawBytes() {}
	public virtual string GetRemoteName() {}
	public virtual string GetServerName() {}
	public virtual long GetConnectionID() {}
	public virtual long GetUrlContextID() {}
	public virtual string GetAppPoolID() {}
	public virtual int GetRequestReason() {}
	public virtual System.IntPtr GetUserToken() {}
	public virtual System.IntPtr GetVirtualPathToken() {}
	public virtual bool IsSecure() {}
	public virtual string GetProtocol() {}
	public virtual string GetFilePath() {}
	public virtual string GetFilePathTranslated() {}
	public virtual string GetPathInfo() {}
	public virtual string GetAppPath() {}
	public virtual string GetAppPathTranslated() {}
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
	public virtual string GetServerVariable(string name) {}
	public virtual long GetBytesRead() {}
	public virtual string MapPath(string virtualPath) {}
	public abstract virtual void SendStatus(int statusCode, string statusDescription) {}
	public abstract virtual void SendKnownResponseHeader(int index, string value) {}
	public abstract virtual void SendUnknownResponseHeader(string name, string value) {}
	public abstract virtual void SendResponseFromMemory(byte[] data, int length) {}
	public virtual void SendResponseFromMemory(System.IntPtr data, int length) {}
	public abstract virtual void SendResponseFromFile(string filename, long offset, long length) {}
	public abstract virtual void SendResponseFromFile(System.IntPtr handle, long offset, long length) {}
	public abstract virtual void FlushResponse(bool finalFlush) {}
	public abstract virtual void EndOfRequest() {}
	public virtual void SetEndOfSendNotification(EndOfSendNotification callback, object extraData) {}
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
	public static string GetStatusDescription(int code) {}
	public static int GetKnownRequestHeaderIndex(string header) {}
	public static string GetKnownRequestHeaderName(int index) {}
	public static int GetKnownResponseHeaderIndex(string header) {}
	public static string GetKnownResponseHeaderName(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int HeaderCacheControl;
	public int HeaderConnection;
	public int HeaderDate;
	public int HeaderKeepAlive;
	public int HeaderPragma;
	public int HeaderTrailer;
	public int HeaderTransferEncoding;
	public int HeaderUpgrade;
	public int HeaderVia;
	public int HeaderWarning;
	public int HeaderAllow;
	public int HeaderContentLength;
	public int HeaderContentType;
	public int HeaderContentEncoding;
	public int HeaderContentLanguage;
	public int HeaderContentLocation;
	public int HeaderContentMd5;
	public int HeaderContentRange;
	public int HeaderExpires;
	public int HeaderLastModified;
	public int HeaderAccept;
	public int HeaderAcceptCharset;
	public int HeaderAcceptEncoding;
	public int HeaderAcceptLanguage;
	public int HeaderAuthorization;
	public int HeaderCookie;
	public int HeaderExpect;
	public int HeaderFrom;
	public int HeaderHost;
	public int HeaderIfMatch;
	public int HeaderIfModifiedSince;
	public int HeaderIfNoneMatch;
	public int HeaderIfRange;
	public int HeaderIfUnmodifiedSince;
	public int HeaderMaxForwards;
	public int HeaderProxyAuthorization;
	public int HeaderReferer;
	public int HeaderRange;
	public int HeaderTe;
	public int HeaderUserAgent;
	public int RequestHeaderMaximum;
	public int HeaderAcceptRanges;
	public int HeaderAge;
	public int HeaderEtag;
	public int HeaderLocation;
	public int HeaderProxyAuthenticate;
	public int HeaderRetryAfter;
	public int HeaderServer;
	public int HeaderSetCookie;
	public int HeaderVary;
	public int HeaderWwwAuthenticate;
	public int ResponseHeaderMaximum;
	public int ReasonResponseCacheMiss;
	public int ReasonFileHandleCacheMiss;
	public int ReasonCachePolicy;
	public int ReasonCacheSecurity;
	public int ReasonClientDisconnect;
	public int ReasonDefault;

	// Properties
	public string MachineConfigPath { get{} }
	public string RootWebConfigPath { get{} }
	public string MachineInstallDirectory { get{} }
	public System.Guid RequestTraceIdentifier { get{} }
}


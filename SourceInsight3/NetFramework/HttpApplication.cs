public class HttpApplication : IHttpAsyncHandler, IHttpHandler, System.ComponentModel.IComponent, System.IDisposable
{

	// Constructors
	public HttpApplication() {}

	// Methods
	public void CompleteRequest() {}
	public void AddOnBeginRequestAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnBeginRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnAuthenticateRequestAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnAuthenticateRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostAuthenticateRequestAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostAuthenticateRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnAuthorizeRequestAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnAuthorizeRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostAuthorizeRequestAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostAuthorizeRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnResolveRequestCacheAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnResolveRequestCacheAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostResolveRequestCacheAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostResolveRequestCacheAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnMapRequestHandlerAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnMapRequestHandlerAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostMapRequestHandlerAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostMapRequestHandlerAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnAcquireRequestStateAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnAcquireRequestStateAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostAcquireRequestStateAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostAcquireRequestStateAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPreRequestHandlerExecuteAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPreRequestHandlerExecuteAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostRequestHandlerExecuteAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostRequestHandlerExecuteAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnReleaseRequestStateAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnReleaseRequestStateAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostReleaseRequestStateAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostReleaseRequestStateAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnUpdateRequestCacheAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnUpdateRequestCacheAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostUpdateRequestCacheAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostUpdateRequestCacheAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnLogRequestAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnLogRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnPostLogRequestAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnPostLogRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public void AddOnEndRequestAsync(BeginEventHandler bh, EndEventHandler eh) {}
	public void AddOnEndRequestAsync(BeginEventHandler beginHandler, EndEventHandler endHandler, object state) {}
	public virtual void Init() {}
	public virtual void Dispose() {}
	public virtual string GetVaryByCustomString(HttpContext context, string custom) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public HttpContext Context { get{} }
	public HttpRequest Request { get{} }
	public HttpResponse Response { get{} }
	public System.Web.SessionState.HttpSessionState Session { get{} }
	public HttpApplicationState Application { get{} }
	public HttpServerUtility Server { get{} }
	public System.Security.Principal.IPrincipal User { get{} }
	public HttpModuleCollection Modules { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }

	// Events
	public event System.EventHandler Disposed;
	public event System.EventHandler BeginRequest;
	public event System.EventHandler AuthenticateRequest;
	public event System.EventHandler PostAuthenticateRequest;
	public event System.EventHandler AuthorizeRequest;
	public event System.EventHandler PostAuthorizeRequest;
	public event System.EventHandler ResolveRequestCache;
	public event System.EventHandler PostResolveRequestCache;
	public event System.EventHandler MapRequestHandler;
	public event System.EventHandler PostMapRequestHandler;
	public event System.EventHandler AcquireRequestState;
	public event System.EventHandler PostAcquireRequestState;
	public event System.EventHandler PreRequestHandlerExecute;
	public event System.EventHandler PostRequestHandlerExecute;
	public event System.EventHandler ReleaseRequestState;
	public event System.EventHandler PostReleaseRequestState;
	public event System.EventHandler UpdateRequestCache;
	public event System.EventHandler PostUpdateRequestCache;
	public event System.EventHandler LogRequest;
	public event System.EventHandler PostLogRequest;
	public event System.EventHandler EndRequest;
	public event System.EventHandler Error;
	public event System.EventHandler PreSendRequestHeaders;
	public event System.EventHandler PreSendRequestContent;
}


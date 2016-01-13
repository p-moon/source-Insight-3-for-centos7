public class Page : TemplateControl, System.ComponentModel.IComponent, System.IDisposable, IParserAccessor, IUrlResolutionService, IDataBindingsAccessor, IControlBuilderAccessor, IControlDesignerAccessor, IExpressionsAccessor, INamingContainer, IFilterResolutionService, System.Web.IHttpHandler
{

	// Constructors
	public Page() {}

	// Methods
	public virtual void VerifyRenderingInServerForm(Control control) {}
	public object GetDataItem() {}
	public static HtmlTextWriter CreateHtmlTextWriterFromType(System.IO.TextWriter tw, Type writerType) {}
	public virtual Control FindControl(string id) {}
	public virtual int GetTypeHashCode() {}
	public void DesignerInitialize() {}
	public void SetFocus(Control control) {}
	public void SetFocus(string clientID) {}
	public string GetPostBackEventReference(Control control) {}
	public string GetPostBackEventReference(Control control, string argument) {}
	public string GetPostBackClientEvent(Control control, string argument) {}
	public string GetPostBackClientHyperlink(Control control, string argument) {}
	public bool IsClientScriptBlockRegistered(string key) {}
	public bool IsStartupScriptRegistered(string key) {}
	public void RegisterArrayDeclaration(string arrayName, string arrayValue) {}
	public virtual void RegisterHiddenField(string hiddenFieldName, string hiddenFieldInitialValue) {}
	public virtual void RegisterClientScriptBlock(string key, string script) {}
	public virtual void RegisterStartupScript(string key, string script) {}
	public void RegisterOnSubmitStatement(string key, string script) {}
	public void RegisterRequiresControlState(Control control) {}
	public bool RequiresControlState(Control control) {}
	public void UnregisterRequiresControlState(Control control) {}
	public void RegisterRequiresPostBack(Control control) {}
	public virtual void RegisterRequiresRaiseEvent(IPostBackEventHandler control) {}
	public string MapPath(string virtualPath) {}
	public void RegisterRequiresViewStateEncryption() {}
	public virtual void ProcessRequest(System.Web.HttpContext context) {}
	public void RegisterViewStateHandler() {}
	public void ExecuteRegisteredAsyncTasks() {}
	public void RegisterAsyncTask(PageAsyncTask task) {}
	public void AddOnPreRenderCompleteAsync(System.Web.BeginEventHandler beginHandler, System.Web.EndEventHandler endHandler) {}
	public void AddOnPreRenderCompleteAsync(System.Web.BeginEventHandler beginHandler, System.Web.EndEventHandler endHandler, object state) {}
	public virtual void Validate() {}
	public virtual void Validate(string validationGroup) {}
	public ValidatorCollection GetValidators(string validationGroup) {}
	public object ReadStringResource() {}
	public virtual bool TestDeviceFilter(string filterName) {}
	public Control LoadControl(string virtualPath) {}
	public Control LoadControl(Type t, object[] parameters) {}
	public ITemplate LoadTemplate(string virtualPath) {}
	public Control ParseControl(string content) {}
	public Control ParseControl(string content, bool ignoreParserFilter) {}
	public virtual void ApplyStyleSheetSkin(Page page) {}
	public virtual void DataBind() {}
	public virtual void Focus() {}
	public virtual void RenderControl(HtmlTextWriter writer) {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public virtual bool HasControls() {}
	public void SetRenderMethodDelegate(RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string postEventSourceID;
	public string postEventArgumentID;

	// Properties
	public System.Web.HttpApplicationState Application { get{} }
	public ClientScriptManager ClientScript { get{} }
	public string ClientTarget { get{} set{} }
	public string ClientQueryString { get{} }
	public string ErrorPage { get{} set{} }
	public bool IsCallback { get{} }
	public bool IsReusable { get{} }
	public System.Web.UI.HtmlControls.HtmlHead Header { get{} }
	public char IdSeparator { get{} }
	public bool MaintainScrollPositionOnPostBack { get{} set{} }
	public MasterPage Master { get{} }
	public string MasterPageFile { get{} set{} }
	public int MaxPageStateFieldLength { get{} set{} }
	public System.Web.TraceContext Trace { get{} }
	public System.Web.HttpRequest Request { get{} }
	public System.Web.HttpResponse Response { get{} }
	public System.Web.HttpServerUtility Server { get{} }
	public System.Web.Caching.Cache Cache { get{} }
	public System.Web.SessionState.HttpSessionState Session { get{} }
	public string Title { get{} set{} }
	public string Theme { get{} set{} }
	public string StyleSheetTheme { get{} set{} }
	public System.Security.Principal.IPrincipal User { get{} }
	public bool IsCrossPagePostBack { get{} }
	public bool IsPostBack { get{} }
	public bool EnableEventValidation { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public ViewStateEncryptionMode ViewStateEncryptionMode { get{} set{} }
	public string ViewStateUserKey { get{} set{} }
	public string ID { get{} set{} }
	public bool Visible { get{} set{} }
	public bool IsValid { get{} }
	public ValidatorCollection Validators { get{} }
	public Page PreviousPage { get{} }
	public bool Buffer { get{} set{} }
	public string ContentType { get{} set{} }
	public int CodePage { get{} set{} }
	public string ResponseEncoding { get{} set{} }
	public string Culture { get{} set{} }
	public int LCID { get{} set{} }
	public string UICulture { get{} set{} }
	public System.TimeSpan AsyncTimeout { get{} set{} }
	public bool TraceEnabled { get{} set{} }
	public System.Web.TraceMode TraceModeValue { get{} set{} }
	public bool EnableViewStateMac { get{} set{} }
	public bool SmartNavigation { get{} set{} }
	public bool IsAsync { get{} }
	public System.Web.UI.HtmlControls.HtmlForm Form { get{} }
	public System.Web.UI.Adapters.PageAdapter PageAdapter { get{} }
	public System.Collections.IDictionary Items { get{} }
	public bool EnableTheming { get{} set{} }
	public string AppRelativeVirtualPath { get{} set{} }
	public string ClientID { get{} }
	public string SkinID { get{} set{} }
	public Control NamingContainer { get{} }
	public Control BindingContainer { get{} }
	public Page Page { get{} set{} }
	public TemplateControl TemplateControl { get{} set{} }
	public Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public string UniqueID { get{} }
	public ControlCollection Controls { get{} }

	// Events
	public event System.EventHandler LoadComplete;
	public event System.EventHandler PreInit;
	public event System.EventHandler PreLoad;
	public event System.EventHandler PreRenderComplete;
	public event System.EventHandler InitComplete;
	public event System.EventHandler SaveStateComplete;
	public event System.EventHandler CommitTransaction;
	public event System.EventHandler AbortTransaction;
	public event System.EventHandler Error;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


public class MobilePage : System.Web.UI.Page, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.INamingContainer, System.Web.UI.IFilterResolutionService, System.Web.IHttpHandler
{

	// Constructors
	public MobilePage() {}

	// Methods
	public virtual IControlAdapter GetControlAdapter(MobileControl control) {}
	public string MakePathAbsolute(string virtualPath) {}
	public Form GetForm(string id) {}
	public void RedirectToMobilePage(string url) {}
	public void RedirectToMobilePage(string url, bool endResponse) {}
	public virtual void Validate() {}
	public virtual void VerifyRenderingInServerForm(System.Web.UI.Control control) {}
	public bool HasHiddenVariables() {}
	public object GetPrivateViewState(MobileControl ctl) {}
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public object GetDataItem() {}
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual int GetTypeHashCode() {}
	public void DesignerInitialize() {}
	public void SetFocus(System.Web.UI.Control control) {}
	public void SetFocus(string clientID) {}
	public string GetPostBackEventReference(System.Web.UI.Control control) {}
	public string GetPostBackEventReference(System.Web.UI.Control control, string argument) {}
	public string GetPostBackClientEvent(System.Web.UI.Control control, string argument) {}
	public string GetPostBackClientHyperlink(System.Web.UI.Control control, string argument) {}
	public bool IsClientScriptBlockRegistered(string key) {}
	public bool IsStartupScriptRegistered(string key) {}
	public void RegisterArrayDeclaration(string arrayName, string arrayValue) {}
	public virtual void RegisterHiddenField(string hiddenFieldName, string hiddenFieldInitialValue) {}
	public virtual void RegisterClientScriptBlock(string key, string script) {}
	public virtual void RegisterStartupScript(string key, string script) {}
	public void RegisterOnSubmitStatement(string key, string script) {}
	public void RegisterRequiresControlState(System.Web.UI.Control control) {}
	public bool RequiresControlState(System.Web.UI.Control control) {}
	public void UnregisterRequiresControlState(System.Web.UI.Control control) {}
	public void RegisterRequiresPostBack(System.Web.UI.Control control) {}
	public virtual void RegisterRequiresRaiseEvent(System.Web.UI.IPostBackEventHandler control) {}
	public string MapPath(string virtualPath) {}
	public void RegisterRequiresViewStateEncryption() {}
	public virtual void ProcessRequest(System.Web.HttpContext context) {}
	public void RegisterViewStateHandler() {}
	public void ExecuteRegisteredAsyncTasks() {}
	public void RegisterAsyncTask(System.Web.UI.PageAsyncTask task) {}
	public void AddOnPreRenderCompleteAsync(System.Web.BeginEventHandler beginHandler, System.Web.EndEventHandler endHandler) {}
	public void AddOnPreRenderCompleteAsync(System.Web.BeginEventHandler beginHandler, System.Web.EndEventHandler endHandler, object state) {}
	public virtual void Validate(string validationGroup) {}
	public System.Web.UI.ValidatorCollection GetValidators(string validationGroup) {}
	public object ReadStringResource() {}
	public virtual bool TestDeviceFilter(string filterName) {}
	public System.Web.UI.Control LoadControl(string virtualPath) {}
	public System.Web.UI.Control LoadControl(Type t, object[] parameters) {}
	public System.Web.UI.ITemplate LoadTemplate(string virtualPath) {}
	public System.Web.UI.Control ParseControl(string content) {}
	public System.Web.UI.Control ParseControl(string content, bool ignoreParserFilter) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public virtual void DataBind() {}
	public virtual void Focus() {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public virtual bool HasControls() {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string HiddenPostEventSourceId;
	public string HiddenPostEventArgumentId;
	public string ViewStateID;
	public string HiddenVariablePrefix;
	public string PageClientViewStateKey;

	// Properties
	public System.Web.Mobile.MobileCapabilities Device { get{} }
	public string MasterPageFile { get{} set{} }
	public bool EnableEventValidation { get{} set{} }
	public StyleSheet StyleSheet { get{} set{} }
	public string Theme { get{} set{} }
	public string Title { get{} set{} }
	public string StyleSheetTheme { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public System.Collections.IList Forms { get{} }
	public bool DesignMode { get{} }
	public IPageAdapter Adapter { get{} }
	public char IdSeparator { get{} }
	public string ClientViewState { get{} }
	public bool AllowCustomAttributes { get{} set{} }
	public string RelativeFilePath { get{} }
	public string AbsoluteFilePath { get{} }
	public string UniqueFilePathSuffix { get{} }
	public string QueryStringText { get{} }
	public Form ActiveForm { get{} set{} }
	public System.Collections.IDictionary HiddenVariables { get{} }
	public System.Web.HttpApplicationState Application { get{} }
	public System.Web.UI.ClientScriptManager ClientScript { get{} }
	public string ClientTarget { get{} set{} }
	public string ClientQueryString { get{} }
	public string ErrorPage { get{} set{} }
	public bool IsCallback { get{} }
	public bool IsReusable { get{} }
	public System.Web.UI.HtmlControls.HtmlHead Header { get{} }
	public bool MaintainScrollPositionOnPostBack { get{} set{} }
	public System.Web.UI.MasterPage Master { get{} }
	public int MaxPageStateFieldLength { get{} set{} }
	public System.Web.TraceContext Trace { get{} }
	public System.Web.HttpRequest Request { get{} }
	public System.Web.HttpResponse Response { get{} }
	public System.Web.HttpServerUtility Server { get{} }
	public System.Web.Caching.Cache Cache { get{} }
	public System.Web.SessionState.HttpSessionState Session { get{} }
	public System.Security.Principal.IPrincipal User { get{} }
	public bool IsCrossPagePostBack { get{} }
	public bool IsPostBack { get{} }
	public bool EnableViewState { get{} set{} }
	public System.Web.UI.ViewStateEncryptionMode ViewStateEncryptionMode { get{} set{} }
	public string ViewStateUserKey { get{} set{} }
	public string ID { get{} set{} }
	public bool Visible { get{} set{} }
	public bool IsValid { get{} }
	public System.Web.UI.ValidatorCollection Validators { get{} }
	public System.Web.UI.Page PreviousPage { get{} }
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
	public string AppRelativeVirtualPath { get{} set{} }
	public string ClientID { get{} }
	public string SkinID { get{} set{} }
	public System.Web.UI.Control NamingContainer { get{} }
	public System.Web.UI.Control BindingContainer { get{} }
	public System.Web.UI.Page Page { get{} set{} }
	public System.Web.UI.TemplateControl TemplateControl { get{} set{} }
	public System.Web.UI.Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public string UniqueID { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }

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


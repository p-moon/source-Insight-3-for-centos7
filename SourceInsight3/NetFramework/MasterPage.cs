public class MasterPage : UserControl, System.ComponentModel.IComponent, System.IDisposable, IParserAccessor, IUrlResolutionService, IDataBindingsAccessor, IControlBuilderAccessor, IControlDesignerAccessor, IExpressionsAccessor, INamingContainer, IFilterResolutionService, IAttributeAccessor, INonBindingContainer, IUserControlDesignerAccessor
{

	// Constructors
	public MasterPage() {}

	// Methods
	public void DesignerInitialize() {}
	public void InitializeAsUserControl(Page page) {}
	public string MapPath(string virtualPath) {}
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
	public virtual Control FindControl(string id) {}
	public virtual bool HasControls() {}
	public void SetRenderMethodDelegate(RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MasterPage Master { get{} }
	public string MasterPageFile { get{} set{} }
	public AttributeCollection Attributes { get{} }
	public System.Web.HttpApplicationState Application { get{} }
	public System.Web.TraceContext Trace { get{} }
	public System.Web.HttpRequest Request { get{} }
	public System.Web.HttpResponse Response { get{} }
	public System.Web.HttpServerUtility Server { get{} }
	public System.Web.Caching.Cache Cache { get{} }
	public ControlCachePolicy CachePolicy { get{} }
	public bool IsPostBack { get{} }
	public System.Web.SessionState.HttpSessionState Session { get{} }
	public bool EnableTheming { get{} set{} }
	public string AppRelativeVirtualPath { get{} set{} }
	public string ClientID { get{} }
	public string ID { get{} set{} }
	public string SkinID { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public Control NamingContainer { get{} }
	public Control BindingContainer { get{} }
	public Page Page { get{} set{} }
	public TemplateControl TemplateControl { get{} set{} }
	public Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public bool Visible { get{} set{} }
	public string UniqueID { get{} }
	public ControlCollection Controls { get{} }

	// Events
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


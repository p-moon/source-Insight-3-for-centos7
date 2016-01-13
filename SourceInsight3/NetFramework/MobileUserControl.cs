public class MobileUserControl : System.Web.UI.UserControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.INamingContainer, System.Web.UI.IFilterResolutionService, System.Web.UI.IAttributeAccessor, System.Web.UI.INonBindingContainer, System.Web.UI.IUserControlDesignerAccessor
{

	// Constructors
	public MobileUserControl() {}

	// Methods
	public void DesignerInitialize() {}
	public void InitializeAsUserControl(System.Web.UI.Page page) {}
	public string MapPath(string virtualPath) {}
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
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual bool HasControls() {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.AttributeCollection Attributes { get{} }
	public System.Web.HttpApplicationState Application { get{} }
	public System.Web.TraceContext Trace { get{} }
	public System.Web.HttpRequest Request { get{} }
	public System.Web.HttpResponse Response { get{} }
	public System.Web.HttpServerUtility Server { get{} }
	public System.Web.Caching.Cache Cache { get{} }
	public System.Web.UI.ControlCachePolicy CachePolicy { get{} }
	public bool IsPostBack { get{} }
	public System.Web.SessionState.HttpSessionState Session { get{} }
	public bool EnableTheming { get{} set{} }
	public string AppRelativeVirtualPath { get{} set{} }
	public string ClientID { get{} }
	public string ID { get{} set{} }
	public string SkinID { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public System.Web.UI.Control NamingContainer { get{} }
	public System.Web.UI.Control BindingContainer { get{} }
	public System.Web.UI.Page Page { get{} set{} }
	public System.Web.UI.TemplateControl TemplateControl { get{} set{} }
	public System.Web.UI.Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public bool Visible { get{} set{} }
	public string UniqueID { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }

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


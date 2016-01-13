public class SiteMapDataSource : System.Web.UI.HierarchicalDataSourceControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IHierarchicalDataSource, System.Web.UI.IDataSource, System.ComponentModel.IListSource
{

	// Constructors
	public SiteMapDataSource() {}

	// Methods
	public virtual System.Collections.IList GetList() {}
	public virtual System.Web.UI.DataSourceView GetView(string viewName) {}
	public virtual System.Collections.ICollection GetViewNames() {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual void Focus() {}
	public virtual bool HasControls() {}
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void DataBind() {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool ContainsListCollection { get{} }
	public System.Web.SiteMapProvider Provider { get{} set{} }
	public bool ShowStartingNode { get{} set{} }
	public string SiteMapProvider { get{} set{} }
	public int StartingNodeOffset { get{} set{} }
	public bool StartFromCurrentNode { get{} set{} }
	public string StartingNodeUrl { get{} set{} }
	public string ClientID { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public bool EnableTheming { get{} set{} }
	public string SkinID { get{} set{} }
	public bool Visible { get{} set{} }
	public string ID { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public System.Web.UI.Control NamingContainer { get{} }
	public System.Web.UI.Control BindingContainer { get{} }
	public System.Web.UI.Page Page { get{} set{} }
	public System.Web.UI.TemplateControl TemplateControl { get{} set{} }
	public System.Web.UI.Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public string UniqueID { get{} }

	// Events
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


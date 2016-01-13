public class XmlDataSource : System.Web.UI.HierarchicalDataSourceControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IHierarchicalDataSource, System.Web.UI.IDataSource, System.ComponentModel.IListSource
{

	// Constructors
	public XmlDataSource() {}

	// Methods
	public System.Xml.XmlDocument GetXmlDocument() {}
	public void Save() {}
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
	public int CacheDuration { get{} set{} }
	public System.Web.UI.DataSourceCacheExpiry CacheExpirationPolicy { get{} set{} }
	public string CacheKeyDependency { get{} set{} }
	public string Data { get{} set{} }
	public string DataFile { get{} set{} }
	public bool EnableCaching { get{} set{} }
	public string Transform { get{} set{} }
	public System.Xml.Xsl.XsltArgumentList TransformArgumentList { get{} set{} }
	public string TransformFile { get{} set{} }
	public string XPath { get{} set{} }
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
	public event System.EventHandler Transforming;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


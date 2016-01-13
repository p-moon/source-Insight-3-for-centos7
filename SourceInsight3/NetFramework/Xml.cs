public class Xml : System.Web.UI.Control, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor
{

	// Constructors
	public Xml() {}

	// Methods
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual void Focus() {}
	public virtual bool HasControls() {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public virtual void DataBind() {}
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ClientID { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public System.Xml.XmlDocument Document { get{} set{} }
	public string DocumentContent { get{} set{} }
	public string DocumentSource { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public string SkinID { get{} set{} }
	public System.Xml.Xsl.XslTransform Transform { get{} set{} }
	public System.Xml.Xsl.XsltArgumentList TransformArgumentList { get{} set{} }
	public string TransformSource { get{} set{} }
	public System.Xml.XPath.XPathNavigator XPathNavigator { get{} set{} }
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
	public bool Visible { get{} set{} }
	public string UniqueID { get{} }

	// Events
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


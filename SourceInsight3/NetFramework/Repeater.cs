public class Repeater : System.Web.UI.Control, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.INamingContainer
{

	// Constructors
	public Repeater() {}

	// Methods
	public virtual void DataBind() {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
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
	public System.Web.UI.ITemplate AlternatingItemTemplate { get{} set{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public string DataMember { get{} set{} }
	public object DataSource { get{} set{} }
	public string DataSourceID { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public System.Web.UI.ITemplate FooterTemplate { get{} set{} }
	public System.Web.UI.ITemplate HeaderTemplate { get{} set{} }
	public RepeaterItemCollection Items { get{} }
	public System.Web.UI.ITemplate ItemTemplate { get{} set{} }
	public System.Web.UI.ITemplate SeparatorTemplate { get{} set{} }
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

	// Events
	public event System.Web.UI.WebControls.RepeaterCommandEventHandler ItemCommand;
	public event System.Web.UI.WebControls.RepeaterItemEventHandler ItemCreated;
	public event System.Web.UI.WebControls.RepeaterItemEventHandler ItemDataBound;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


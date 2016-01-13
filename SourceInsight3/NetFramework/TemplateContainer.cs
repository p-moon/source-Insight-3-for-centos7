public class TemplateContainer : Panel, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, ITemplateable, System.Web.UI.INamingContainer
{

	// Constructors
	public TemplateContainer() {}

	// Methods
	public virtual void AddLinkedForms(System.Collections.IList linkedForms) {}
	public virtual void PaginateRecursive(ControlPager pager) {}
	public virtual void CreateDefaultTemplatedUI(bool doDataBind) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public Form ResolveFormReference(string formID) {}
	public virtual System.Web.UI.ITemplate GetTemplate(string templateName) {}
	public virtual void EnsureTemplatedUI() {}
	public string ResolveUrl(string relativeUrl) {}
	public void RenderChildren(System.Web.UI.HtmlTextWriter writer) {}
	public bool IsVisibleOnPage(int pageNumber) {}
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
	public bool BreakAfter { get{} set{} }
	public bool Paginate { get{} set{} }
	public Panel Content { get{} }
	public IControlAdapter Adapter { get{} }
	public bool EnableTheming { get{} set{} }
	public MobilePage MobilePage { get{} }
	public Form Form { get{} }
	public string SkinID { get{} set{} }
	public bool IsTemplated { get{} }
	public DeviceSpecific DeviceSpecific { get{} set{} }
	public System.Web.UI.StateBag CustomAttributes { get{} }
	public string StyleReference { get{} set{} }
	public FontInfo Font { get{} }
	public Alignment Alignment { get{} set{} }
	public Wrapping Wrapping { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public int FirstPage { get{} set{} }
	public int LastPage { get{} set{} }
	public int VisibleWeight { get{} }
	public string ClientID { get{} }
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
	public System.Web.UI.ControlCollection Controls { get{} }

	// Events
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


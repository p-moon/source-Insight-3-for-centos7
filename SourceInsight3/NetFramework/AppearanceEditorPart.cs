public class AppearanceEditorPart : EditorPart, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, System.Web.UI.WebControls.ICompositeControlDesignerAccessor
{

	// Constructors
	public AppearanceEditorPart() {}

	// Methods
	public virtual bool ApplyChanges() {}
	public virtual void SyncChanges() {}
	public virtual void DataBind() {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void RenderEndTag(System.Web.UI.HtmlTextWriter writer) {}
	public void ApplyStyle(System.Web.UI.WebControls.Style s) {}
	public void CopyBaseAttributes(System.Web.UI.WebControls.WebControl controlSrc) {}
	public void MergeStyle(System.Web.UI.WebControls.Style s) {}
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
	public string DefaultButton { get{} set{} }
	public string Title { get{} set{} }
	public bool Display { get{} }
	public string DisplayTitle { get{} }
	public PartChromeState ChromeState { get{} set{} }
	public PartChromeType ChromeType { get{} set{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public string Description { get{} set{} }
	public string BackImageUrl { get{} set{} }
	public System.Web.UI.WebControls.ContentDirection Direction { get{} set{} }
	public string GroupingText { get{} set{} }
	public System.Web.UI.WebControls.HorizontalAlign HorizontalAlign { get{} set{} }
	public System.Web.UI.WebControls.ScrollBars ScrollBars { get{} set{} }
	public bool Wrap { get{} set{} }
	public string AccessKey { get{} set{} }
	public System.Web.UI.AttributeCollection Attributes { get{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color BorderColor { get{} set{} }
	public System.Web.UI.WebControls.Unit BorderWidth { get{} set{} }
	public System.Web.UI.WebControls.BorderStyle BorderStyle { get{} set{} }
	public System.Web.UI.WebControls.Style ControlStyle { get{} }
	public bool ControlStyleCreated { get{} }
	public string CssClass { get{} set{} }
	public System.Web.UI.CssStyleCollection Style { get{} }
	public bool Enabled { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public System.Web.UI.WebControls.FontInfo Font { get{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public bool HasAttributes { get{} }
	public System.Web.UI.WebControls.Unit Height { get{} set{} }
	public string SkinID { get{} set{} }
	public short TabIndex { get{} set{} }
	public string ToolTip { get{} set{} }
	public System.Web.UI.WebControls.Unit Width { get{} set{} }
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

	// Events
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


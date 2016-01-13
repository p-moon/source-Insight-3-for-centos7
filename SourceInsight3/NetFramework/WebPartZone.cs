public class WebPartZone : WebPartZoneBase, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, System.Web.UI.WebControls.ICompositeControlDesignerAccessor, System.Web.UI.IPostBackEventHandler, IWebPartMenuUser
{

	// Constructors
	public WebPartZone() {}

	// Methods
	public virtual PartChromeType GetEffectiveChromeType(Part part) {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void DataBind() {}
	public void ApplyStyle(System.Web.UI.WebControls.Style s) {}
	public void CopyBaseAttributes(System.Web.UI.WebControls.WebControl controlSrc) {}
	public void MergeStyle(System.Web.UI.WebControls.Style s) {}
	public virtual void RenderEndTag(System.Web.UI.HtmlTextWriter writer) {}
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
	public System.Web.UI.ITemplate ZoneTemplate { get{} set{} }
	public bool AllowLayoutChange { get{} set{} }
	public System.Drawing.Color BorderColor { get{} set{} }
	public System.Web.UI.WebControls.BorderStyle BorderStyle { get{} set{} }
	public System.Web.UI.WebControls.Unit BorderWidth { get{} set{} }
	public WebPartVerb CloseVerb { get{} }
	public WebPartVerb ConnectVerb { get{} }
	public WebPartVerb DeleteVerb { get{} }
	public string DisplayTitle { get{} }
	public System.Drawing.Color DragHighlightColor { get{} set{} }
	public WebPartVerb EditVerb { get{} }
	public string EmptyZoneText { get{} set{} }
	public WebPartVerb ExportVerb { get{} }
	public WebPartVerb HelpVerb { get{} }
	public System.Web.UI.WebControls.Style MenuCheckImageStyle { get{} }
	public string MenuCheckImageUrl { get{} set{} }
	public System.Web.UI.WebControls.Style MenuLabelHoverStyle { get{} }
	public System.Web.UI.WebControls.Style MenuLabelStyle { get{} }
	public string MenuLabelText { get{} set{} }
	public string MenuPopupImageUrl { get{} set{} }
	public WebPartMenuStyle MenuPopupStyle { get{} }
	public System.Web.UI.WebControls.Style MenuVerbHoverStyle { get{} }
	public System.Web.UI.WebControls.Style MenuVerbStyle { get{} }
	public WebPartVerb MinimizeVerb { get{} }
	public System.Web.UI.WebControls.Orientation LayoutOrientation { get{} set{} }
	public WebPartVerb RestoreVerb { get{} }
	public System.Web.UI.WebControls.Style SelectedPartChromeStyle { get{} }
	public bool ShowTitleIcons { get{} set{} }
	public System.Web.UI.WebControls.ButtonType TitleBarVerbButtonType { get{} set{} }
	public System.Web.UI.WebControls.Style TitleBarVerbStyle { get{} }
	public System.Web.UI.WebControls.ButtonType VerbButtonType { get{} set{} }
	public WebPartChrome WebPartChrome { get{} }
	public WebPartCollection WebParts { get{} }
	public WebPartVerbRenderMode WebPartVerbRenderMode { get{} set{} }
	public string BackImageUrl { get{} set{} }
	public System.Web.UI.WebControls.Style EmptyZoneTextStyle { get{} }
	public System.Web.UI.WebControls.Style ErrorStyle { get{} }
	public TitleStyle FooterStyle { get{} }
	public string HeaderText { get{} set{} }
	public TitleStyle HeaderStyle { get{} }
	public System.Web.UI.WebControls.Unit PartChromePadding { get{} set{} }
	public System.Web.UI.WebControls.Style PartChromeStyle { get{} }
	public PartChromeType PartChromeType { get{} set{} }
	public System.Web.UI.WebControls.TableStyle PartStyle { get{} }
	public TitleStyle PartTitleStyle { get{} }
	public int Padding { get{} set{} }
	public System.Web.UI.WebControls.Style VerbStyle { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public string AccessKey { get{} set{} }
	public System.Web.UI.AttributeCollection Attributes { get{} }
	public System.Drawing.Color BackColor { get{} set{} }
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
	public event System.Web.UI.WebControls.WebParts.WebPartVerbsEventHandler CreateVerbs;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


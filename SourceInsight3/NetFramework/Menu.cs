public class Menu : HierarchicalDataBoundControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.IPostBackEventHandler, System.Web.UI.INamingContainer
{

	// Constructors
	public Menu() {}

	// Methods
	public virtual void DataBind() {}
	public MenuItem FindItem(string valuePath) {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void RenderEndTag(System.Web.UI.HtmlTextWriter writer) {}
	public void ApplyStyle(Style s) {}
	public void CopyBaseAttributes(WebControl controlSrc) {}
	public void MergeStyle(Style s) {}
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

	// Fields
	public string MenuItemClickCommandName;

	// Properties
	public System.Web.UI.ControlCollection Controls { get{} }
	public MenuItemBindingCollection DataBindings { get{} }
	public int DisappearAfter { get{} set{} }
	public string DynamicBottomSeparatorImageUrl { get{} set{} }
	public bool DynamicEnableDefaultPopOutImage { get{} set{} }
	public int DynamicHorizontalOffset { get{} set{} }
	public Style DynamicHoverStyle { get{} }
	public string DynamicItemFormatString { get{} set{} }
	public MenuItemStyle DynamicMenuItemStyle { get{} }
	public SubMenuStyle DynamicMenuStyle { get{} }
	public string DynamicPopOutImageUrl { get{} set{} }
	public string DynamicPopOutImageTextFormatString { get{} set{} }
	public MenuItemStyle DynamicSelectedStyle { get{} }
	public System.Web.UI.ITemplate DynamicItemTemplate { get{} set{} }
	public string DynamicTopSeparatorImageUrl { get{} set{} }
	public int DynamicVerticalOffset { get{} set{} }
	public MenuItemCollection Items { get{} }
	public bool ItemWrap { get{} set{} }
	public MenuItemStyleCollection LevelMenuItemStyles { get{} }
	public MenuItemStyleCollection LevelSelectedStyles { get{} }
	public SubMenuStyleCollection LevelSubMenuStyles { get{} }
	public int MaximumDynamicDisplayLevels { get{} set{} }
	public Orientation Orientation { get{} set{} }
	public char PathSeparator { get{} set{} }
	public string ScrollDownImageUrl { get{} set{} }
	public string ScrollDownText { get{} set{} }
	public string ScrollUpImageUrl { get{} set{} }
	public string ScrollUpText { get{} set{} }
	public MenuItem SelectedItem { get{} }
	public string SelectedValue { get{} }
	public string SkipLinkText { get{} set{} }
	public string StaticBottomSeparatorImageUrl { get{} set{} }
	public int StaticDisplayLevels { get{} set{} }
	public bool StaticEnableDefaultPopOutImage { get{} set{} }
	public Style StaticHoverStyle { get{} }
	public string StaticItemFormatString { get{} set{} }
	public MenuItemStyle StaticMenuItemStyle { get{} }
	public SubMenuStyle StaticMenuStyle { get{} }
	public string StaticPopOutImageUrl { get{} set{} }
	public string StaticPopOutImageTextFormatString { get{} set{} }
	public MenuItemStyle StaticSelectedStyle { get{} }
	public Unit StaticSubMenuIndent { get{} set{} }
	public System.Web.UI.ITemplate StaticItemTemplate { get{} set{} }
	public string StaticTopSeparatorImageUrl { get{} set{} }
	public string Target { get{} set{} }
	public string DataSourceID { get{} set{} }
	public object DataSource { get{} set{} }
	public string AccessKey { get{} set{} }
	public System.Web.UI.AttributeCollection Attributes { get{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color BorderColor { get{} set{} }
	public Unit BorderWidth { get{} set{} }
	public BorderStyle BorderStyle { get{} set{} }
	public Style ControlStyle { get{} }
	public bool ControlStyleCreated { get{} }
	public string CssClass { get{} set{} }
	public System.Web.UI.CssStyleCollection Style { get{} }
	public bool Enabled { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public FontInfo Font { get{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public bool HasAttributes { get{} }
	public Unit Height { get{} set{} }
	public string SkinID { get{} set{} }
	public short TabIndex { get{} set{} }
	public string ToolTip { get{} set{} }
	public Unit Width { get{} set{} }
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
	public event System.Web.UI.WebControls.MenuEventHandler MenuItemClick;
	public event System.Web.UI.WebControls.MenuEventHandler MenuItemDataBound;
	public event System.EventHandler DataBound;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


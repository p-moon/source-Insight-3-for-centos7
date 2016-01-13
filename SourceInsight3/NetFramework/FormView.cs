public class FormView : CompositeDataBoundControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, System.Web.UI.IDataItemContainer, System.Web.UI.IPostBackEventHandler, IPostBackContainer
{

	// Constructors
	public FormView() {}

	// Methods
	public void ChangeMode(FormViewMode newMode) {}
	public virtual void DataBind() {}
	public virtual void DeleteItem() {}
	public virtual void InsertItem(bool causesValidation) {}
	public virtual bool IsBindableType(Type type) {}
	public virtual void UpdateItem(bool causesValidation) {}
	public void ApplyStyle(Style s) {}
	public void CopyBaseAttributes(WebControl controlSrc) {}
	public void MergeStyle(Style s) {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) {}
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
	public bool AllowPaging { get{} set{} }
	public string BackImageUrl { get{} set{} }
	public FormViewRow BottomPagerRow { get{} }
	public string Caption { get{} set{} }
	public TableCaptionAlign CaptionAlign { get{} set{} }
	public int CellPadding { get{} set{} }
	public int CellSpacing { get{} set{} }
	public FormViewMode CurrentMode { get{} }
	public object DataItem { get{} }
	public int DataItemCount { get{} }
	public int DataItemIndex { get{} }
	public string[] DataKeyNames { get{} set{} }
	public DataKey DataKey { get{} }
	public FormViewMode DefaultMode { get{} set{} }
	public System.Web.UI.ITemplate EditItemTemplate { get{} set{} }
	public TableItemStyle EditRowStyle { get{} }
	public TableItemStyle EmptyDataRowStyle { get{} }
	public System.Web.UI.ITemplate EmptyDataTemplate { get{} set{} }
	public string EmptyDataText { get{} set{} }
	public FormViewRow FooterRow { get{} }
	public TableItemStyle FooterStyle { get{} }
	public System.Web.UI.ITemplate FooterTemplate { get{} set{} }
	public string FooterText { get{} set{} }
	public GridLines GridLines { get{} set{} }
	public FormViewRow HeaderRow { get{} }
	public TableItemStyle HeaderStyle { get{} }
	public System.Web.UI.ITemplate HeaderTemplate { get{} set{} }
	public string HeaderText { get{} set{} }
	public HorizontalAlign HorizontalAlign { get{} set{} }
	public System.Web.UI.ITemplate InsertItemTemplate { get{} set{} }
	public TableItemStyle InsertRowStyle { get{} }
	public System.Web.UI.ITemplate ItemTemplate { get{} set{} }
	public int PageCount { get{} }
	public int PageIndex { get{} set{} }
	public PagerSettings PagerSettings { get{} }
	public TableItemStyle PagerStyle { get{} }
	public System.Web.UI.ITemplate PagerTemplate { get{} set{} }
	public FormViewRow Row { get{} }
	public TableItemStyle RowStyle { get{} }
	public object SelectedValue { get{} }
	public FormViewRow TopPagerRow { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public string DataMember { get{} set{} }
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
	public event System.EventHandler PageIndexChanged;
	public event System.Web.UI.WebControls.FormViewPageEventHandler PageIndexChanging;
	public event System.Web.UI.WebControls.FormViewCommandEventHandler ItemCommand;
	public event System.EventHandler ItemCreated;
	public event System.Web.UI.WebControls.FormViewDeletedEventHandler ItemDeleted;
	public event System.Web.UI.WebControls.FormViewDeleteEventHandler ItemDeleting;
	public event System.Web.UI.WebControls.FormViewInsertedEventHandler ItemInserted;
	public event System.Web.UI.WebControls.FormViewInsertEventHandler ItemInserting;
	public event System.Web.UI.WebControls.FormViewUpdatedEventHandler ItemUpdated;
	public event System.Web.UI.WebControls.FormViewUpdateEventHandler ItemUpdating;
	public event System.EventHandler ModeChanged;
	public event System.Web.UI.WebControls.FormViewModeEventHandler ModeChanging;
	public event System.EventHandler DataBound;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


public class DataList : BaseDataList, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, IRepeatInfoUser
{

	// Constructors
	public DataList() {}

	// Methods
	public virtual void DataBind() {}
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

	// Fields
	public string SelectCommandName;
	public string EditCommandName;
	public string UpdateCommandName;
	public string CancelCommandName;
	public string DeleteCommandName;

	// Properties
	public TableItemStyle AlternatingItemStyle { get{} }
	public System.Web.UI.ITemplate AlternatingItemTemplate { get{} set{} }
	public int EditItemIndex { get{} set{} }
	public TableItemStyle EditItemStyle { get{} }
	public System.Web.UI.ITemplate EditItemTemplate { get{} set{} }
	public bool ExtractTemplateRows { get{} set{} }
	public TableItemStyle FooterStyle { get{} }
	public System.Web.UI.ITemplate FooterTemplate { get{} set{} }
	public GridLines GridLines { get{} set{} }
	public TableItemStyle HeaderStyle { get{} }
	public System.Web.UI.ITemplate HeaderTemplate { get{} set{} }
	public DataListItemCollection Items { get{} }
	public TableItemStyle ItemStyle { get{} }
	public System.Web.UI.ITemplate ItemTemplate { get{} set{} }
	public int RepeatColumns { get{} set{} }
	public RepeatDirection RepeatDirection { get{} set{} }
	public RepeatLayout RepeatLayout { get{} set{} }
	public int SelectedIndex { get{} set{} }
	public DataListItem SelectedItem { get{} }
	public TableItemStyle SelectedItemStyle { get{} }
	public System.Web.UI.ITemplate SelectedItemTemplate { get{} set{} }
	public object SelectedValue { get{} }
	public TableItemStyle SeparatorStyle { get{} }
	public System.Web.UI.ITemplate SeparatorTemplate { get{} set{} }
	public bool ShowFooter { get{} set{} }
	public bool ShowHeader { get{} set{} }
	public string Caption { get{} set{} }
	public TableCaptionAlign CaptionAlign { get{} set{} }
	public int CellPadding { get{} set{} }
	public int CellSpacing { get{} set{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public DataKeyCollection DataKeys { get{} }
	public string DataKeyField { get{} set{} }
	public string DataMember { get{} set{} }
	public object DataSource { get{} set{} }
	public string DataSourceID { get{} set{} }
	public HorizontalAlign HorizontalAlign { get{} set{} }
	public bool UseAccessibleHeader { get{} set{} }
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
	public event System.Web.UI.WebControls.DataListCommandEventHandler CancelCommand;
	public event System.Web.UI.WebControls.DataListCommandEventHandler DeleteCommand;
	public event System.Web.UI.WebControls.DataListCommandEventHandler EditCommand;
	public event System.Web.UI.WebControls.DataListCommandEventHandler ItemCommand;
	public event System.Web.UI.WebControls.DataListItemEventHandler ItemCreated;
	public event System.Web.UI.WebControls.DataListItemEventHandler ItemDataBound;
	public event System.Web.UI.WebControls.DataListCommandEventHandler UpdateCommand;
	public event System.EventHandler SelectedIndexChanged;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


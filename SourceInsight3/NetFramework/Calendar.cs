public class Calendar : WebControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.IPostBackEventHandler
{

	// Constructors
	public Calendar() {}

	// Methods
	public void ApplyStyle(Style s) {}
	public void CopyBaseAttributes(WebControl controlSrc) {}
	public void MergeStyle(Style s) {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void RenderEndTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
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
	public string Caption { get{} set{} }
	public TableCaptionAlign CaptionAlign { get{} set{} }
	public int CellPadding { get{} set{} }
	public int CellSpacing { get{} set{} }
	public TableItemStyle DayHeaderStyle { get{} }
	public DayNameFormat DayNameFormat { get{} set{} }
	public TableItemStyle DayStyle { get{} }
	public FirstDayOfWeek FirstDayOfWeek { get{} set{} }
	public string NextMonthText { get{} set{} }
	public NextPrevFormat NextPrevFormat { get{} set{} }
	public TableItemStyle NextPrevStyle { get{} }
	public TableItemStyle OtherMonthDayStyle { get{} }
	public string PrevMonthText { get{} set{} }
	public System.DateTime SelectedDate { get{} set{} }
	public SelectedDatesCollection SelectedDates { get{} }
	public TableItemStyle SelectedDayStyle { get{} }
	public CalendarSelectionMode SelectionMode { get{} set{} }
	public string SelectMonthText { get{} set{} }
	public TableItemStyle SelectorStyle { get{} }
	public string SelectWeekText { get{} set{} }
	public bool ShowDayHeader { get{} set{} }
	public bool ShowGridLines { get{} set{} }
	public bool ShowNextPrevMonth { get{} set{} }
	public bool ShowTitle { get{} set{} }
	public TitleFormat TitleFormat { get{} set{} }
	public TableItemStyle TitleStyle { get{} }
	public TableItemStyle TodayDayStyle { get{} }
	public System.DateTime TodaysDate { get{} set{} }
	public bool UseAccessibleHeader { get{} set{} }
	public System.DateTime VisibleDate { get{} set{} }
	public TableItemStyle WeekendDayStyle { get{} }
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
	public System.Web.UI.ControlCollection Controls { get{} }

	// Events
	public event System.Web.UI.WebControls.DayRenderEventHandler DayRender;
	public event System.EventHandler SelectionChanged;
	public event System.Web.UI.WebControls.MonthChangedEventHandler VisibleMonthChanged;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


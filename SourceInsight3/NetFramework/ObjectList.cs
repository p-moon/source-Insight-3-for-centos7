public class ObjectList : PagedControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, ITemplateable, System.Web.UI.IPostBackEventHandler
{

	// Constructors
	public ObjectList() {}

	// Methods
	public virtual void EnsureTemplatedUI() {}
	public virtual void DataBind() {}
	public void CreateTemplatedItemsList(bool doDataBind) {}
	public void CreateTemplatedItemDetails(bool doDataBind) {}
	public void RaiseDefaultItemEvent(int itemIndex) {}
	public bool SelectListItem(int itemIndex, bool selectMore) {}
	public void PreShowItemCommands(int itemIndex) {}
	public virtual void PaginateRecursive(ControlPager pager) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public Form ResolveFormReference(string formID) {}
	public virtual System.Web.UI.ITemplate GetTemplate(string templateName) {}
	public virtual void CreateDefaultTemplatedUI(bool doDataBind) {}
	public string ResolveUrl(string relativeUrl) {}
	public void RenderChildren(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void AddLinkedForms(System.Collections.IList linkedForms) {}
	public bool IsVisibleOnPage(int pageNumber) {}
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
	public string SelectMoreCommand { get{} }
	public object DataSource { get{} set{} }
	public string DataMember { get{} set{} }
	public ObjectListFieldCollection Fields { get{} }
	public ObjectListItemCollection Items { get{} }
	public ObjectListCommandCollection Commands { get{} }
	public string LabelField { get{} set{} }
	public string DefaultCommand { get{} set{} }
	public string TableFields { get{} set{} }
	public int SelectedIndex { get{} set{} }
	public ObjectListItem Selection { get{} }
	public bool AutoGenerateFields { get{} set{} }
	public IObjectListFieldCollection AllFields { get{} }
	public int LabelFieldIndex { get{} }
	public Panel Details { get{} }
	public int[] TableFieldIndices { get{} }
	public bool HasItemCommandHandler { get{} }
	public ObjectListViewMode ViewMode { get{} set{} }
	public string DetailsCommandText { get{} set{} }
	public string BackCommandText { get{} set{} }
	public string MoreText { get{} set{} }
	public Style CommandStyle { get{} set{} }
	public Style LabelStyle { get{} set{} }
	public int ItemCount { get{} set{} }
	public int ItemsPerPage { get{} set{} }
	public int FirstVisibleItemIndex { get{} }
	public int VisibleItemCount { get{} }
	public int VisibleWeight { get{} }
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
	public bool BreakAfter { get{} set{} }
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
	public event System.Web.UI.MobileControls.ObjectListDataBindEventHandler ItemDataBind;
	public event System.Web.UI.MobileControls.ObjectListCommandEventHandler ItemCommand;
	public event System.Web.UI.MobileControls.ObjectListSelectEventHandler ItemSelect;
	public event System.Web.UI.MobileControls.ObjectListShowCommandsEventHandler ShowItemCommands;
	public event System.Web.UI.MobileControls.LoadItemsEventHandler LoadItems;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


public class ObjectDataSource : System.Web.UI.DataSourceControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IDataSource, System.ComponentModel.IListSource
{

	// Constructors
	public ObjectDataSource() {}
	public ObjectDataSource(string typeName, string selectMethod) {}

	// Methods
	public int Delete() {}
	public int Insert() {}
	public System.Collections.IEnumerable Select() {}
	public int Update() {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual void Focus() {}
	public virtual bool HasControls() {}
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void DataBind() {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int CacheDuration { get{} set{} }
	public System.Web.UI.DataSourceCacheExpiry CacheExpirationPolicy { get{} set{} }
	public string CacheKeyDependency { get{} set{} }
	public System.Web.UI.ConflictOptions ConflictDetection { get{} set{} }
	public bool ConvertNullToDBNull { get{} set{} }
	public string DataObjectTypeName { get{} set{} }
	public string DeleteMethod { get{} set{} }
	public ParameterCollection DeleteParameters { get{} }
	public bool EnableCaching { get{} set{} }
	public bool EnablePaging { get{} set{} }
	public string FilterExpression { get{} set{} }
	public ParameterCollection FilterParameters { get{} }
	public string InsertMethod { get{} set{} }
	public ParameterCollection InsertParameters { get{} }
	public string MaximumRowsParameterName { get{} set{} }
	public string OldValuesParameterFormatString { get{} set{} }
	public string SelectCountMethod { get{} set{} }
	public string SelectMethod { get{} set{} }
	public ParameterCollection SelectParameters { get{} }
	public string SortParameterName { get{} set{} }
	public string SqlCacheDependency { get{} set{} }
	public string StartRowIndexParameterName { get{} set{} }
	public string TypeName { get{} set{} }
	public string UpdateMethod { get{} set{} }
	public ParameterCollection UpdateParameters { get{} }
	public string ClientID { get{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public bool EnableTheming { get{} set{} }
	public string SkinID { get{} set{} }
	public bool Visible { get{} set{} }
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
	public string UniqueID { get{} }

	// Events
	public event System.Web.UI.WebControls.ObjectDataSourceStatusEventHandler Deleted;
	public event System.Web.UI.WebControls.ObjectDataSourceMethodEventHandler Deleting;
	public event System.Web.UI.WebControls.ObjectDataSourceFilteringEventHandler Filtering;
	public event System.Web.UI.WebControls.ObjectDataSourceStatusEventHandler Inserted;
	public event System.Web.UI.WebControls.ObjectDataSourceMethodEventHandler Inserting;
	public event System.Web.UI.WebControls.ObjectDataSourceObjectEventHandler ObjectCreated;
	public event System.Web.UI.WebControls.ObjectDataSourceObjectEventHandler ObjectCreating;
	public event System.Web.UI.WebControls.ObjectDataSourceDisposingEventHandler ObjectDisposing;
	public event System.Web.UI.WebControls.ObjectDataSourceStatusEventHandler Selected;
	public event System.Web.UI.WebControls.ObjectDataSourceSelectingEventHandler Selecting;
	public event System.Web.UI.WebControls.ObjectDataSourceStatusEventHandler Updated;
	public event System.Web.UI.WebControls.ObjectDataSourceMethodEventHandler Updating;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


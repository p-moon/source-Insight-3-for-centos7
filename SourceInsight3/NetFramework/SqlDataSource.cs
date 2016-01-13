public class SqlDataSource : System.Web.UI.DataSourceControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IDataSource, System.ComponentModel.IListSource
{

	// Constructors
	public SqlDataSource() {}
	public SqlDataSource(string connectionString, string selectCommand) {}
	public SqlDataSource(string providerName, string connectionString, string selectCommand) {}

	// Methods
	public int Delete() {}
	public int Insert() {}
	public System.Collections.IEnumerable Select(System.Web.UI.DataSourceSelectArguments arguments) {}
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
	public bool CancelSelectOnNullParameter { get{} set{} }
	public System.Web.UI.ConflictOptions ConflictDetection { get{} set{} }
	public string ConnectionString { get{} set{} }
	public SqlDataSourceMode DataSourceMode { get{} set{} }
	public string DeleteCommand { get{} set{} }
	public SqlDataSourceCommandType DeleteCommandType { get{} set{} }
	public ParameterCollection DeleteParameters { get{} }
	public bool EnableCaching { get{} set{} }
	public string FilterExpression { get{} set{} }
	public ParameterCollection FilterParameters { get{} }
	public string InsertCommand { get{} set{} }
	public SqlDataSourceCommandType InsertCommandType { get{} set{} }
	public ParameterCollection InsertParameters { get{} }
	public string OldValuesParameterFormatString { get{} set{} }
	public string ProviderName { get{} set{} }
	public string SelectCommand { get{} set{} }
	public SqlDataSourceCommandType SelectCommandType { get{} set{} }
	public ParameterCollection SelectParameters { get{} }
	public string SortParameterName { get{} set{} }
	public string SqlCacheDependency { get{} set{} }
	public string UpdateCommand { get{} set{} }
	public SqlDataSourceCommandType UpdateCommandType { get{} set{} }
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
	public event System.Web.UI.WebControls.SqlDataSourceStatusEventHandler Deleted;
	public event System.Web.UI.WebControls.SqlDataSourceCommandEventHandler Deleting;
	public event System.Web.UI.WebControls.SqlDataSourceFilteringEventHandler Filtering;
	public event System.Web.UI.WebControls.SqlDataSourceStatusEventHandler Inserted;
	public event System.Web.UI.WebControls.SqlDataSourceCommandEventHandler Inserting;
	public event System.Web.UI.WebControls.SqlDataSourceStatusEventHandler Selected;
	public event System.Web.UI.WebControls.SqlDataSourceSelectingEventHandler Selecting;
	public event System.Web.UI.WebControls.SqlDataSourceStatusEventHandler Updated;
	public event System.Web.UI.WebControls.SqlDataSourceCommandEventHandler Updating;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}


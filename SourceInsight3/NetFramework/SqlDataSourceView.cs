public class SqlDataSourceView : System.Web.UI.DataSourceView, System.Web.UI.IStateManager
{

	// Constructors
	public SqlDataSourceView(SqlDataSource owner, string name, System.Web.HttpContext context) {}

	// Methods
	public int Delete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) {}
	public int Insert(System.Collections.IDictionary values) {}
	public System.Collections.IEnumerable Select(System.Web.UI.DataSourceSelectArguments arguments) {}
	public int Update(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) {}
	public virtual void Delete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues, System.Web.UI.DataSourceViewOperationCallback callback) {}
	public virtual void Insert(System.Collections.IDictionary values, System.Web.UI.DataSourceViewOperationCallback callback) {}
	public virtual void Select(System.Web.UI.DataSourceSelectArguments arguments, System.Web.UI.DataSourceViewSelectCallback callback) {}
	public virtual void Update(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues, System.Web.UI.DataSourceViewOperationCallback callback) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CancelSelectOnNullParameter { get{} set{} }
	public bool CanDelete { get{} }
	public bool CanInsert { get{} }
	public bool CanPage { get{} }
	public bool CanRetrieveTotalRowCount { get{} }
	public bool CanSort { get{} }
	public bool CanUpdate { get{} }
	public System.Web.UI.ConflictOptions ConflictDetection { get{} set{} }
	public string DeleteCommand { get{} set{} }
	public SqlDataSourceCommandType DeleteCommandType { get{} set{} }
	public ParameterCollection DeleteParameters { get{} }
	public string FilterExpression { get{} set{} }
	public ParameterCollection FilterParameters { get{} }
	public string InsertCommand { get{} set{} }
	public SqlDataSourceCommandType InsertCommandType { get{} set{} }
	public ParameterCollection InsertParameters { get{} }
	public string OldValuesParameterFormatString { get{} set{} }
	public string SelectCommand { get{} set{} }
	public SqlDataSourceCommandType SelectCommandType { get{} set{} }
	public ParameterCollection SelectParameters { get{} }
	public string SortParameterName { get{} set{} }
	public string UpdateCommand { get{} set{} }
	public SqlDataSourceCommandType UpdateCommandType { get{} set{} }
	public ParameterCollection UpdateParameters { get{} }
	public string Name { get{} }

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
	public event System.EventHandler DataSourceViewChanged;
}


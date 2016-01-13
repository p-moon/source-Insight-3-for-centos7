public class ObjectDataSourceView : System.Web.UI.DataSourceView, System.Web.UI.IStateManager
{

	// Constructors
	public ObjectDataSourceView(ObjectDataSource owner, string name, System.Web.HttpContext context) {}

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
	public bool CanDelete { get{} }
	public bool CanInsert { get{} }
	public bool CanPage { get{} }
	public bool CanRetrieveTotalRowCount { get{} }
	public bool CanSort { get{} }
	public bool CanUpdate { get{} }
	public System.Web.UI.ConflictOptions ConflictDetection { get{} set{} }
	public bool ConvertNullToDBNull { get{} set{} }
	public string DataObjectTypeName { get{} set{} }
	public string DeleteMethod { get{} set{} }
	public ParameterCollection DeleteParameters { get{} }
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
	public string StartRowIndexParameterName { get{} set{} }
	public string TypeName { get{} set{} }
	public string UpdateMethod { get{} set{} }
	public ParameterCollection UpdateParameters { get{} }
	public string Name { get{} }

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
	public event System.EventHandler DataSourceViewChanged;
}


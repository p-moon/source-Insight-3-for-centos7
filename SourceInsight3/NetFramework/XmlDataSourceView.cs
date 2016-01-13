public class XmlDataSourceView : System.Web.UI.DataSourceView
{

	// Constructors
	public XmlDataSourceView(XmlDataSource owner, string name) {}

	// Methods
	public System.Collections.IEnumerable Select(System.Web.UI.DataSourceSelectArguments arguments) {}
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
	public string Name { get{} }

	// Events
	public event System.EventHandler DataSourceViewChanged;
}


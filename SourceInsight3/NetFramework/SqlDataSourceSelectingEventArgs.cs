public class SqlDataSourceSelectingEventArgs : SqlDataSourceCommandEventArgs
{

	// Constructors
	public SqlDataSourceSelectingEventArgs(System.Data.Common.DbCommand command, System.Web.UI.DataSourceSelectArguments arguments) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.DataSourceSelectArguments Arguments { get{} }
	public System.Data.Common.DbCommand Command { get{} }
	public bool Cancel { get{} set{} }
}


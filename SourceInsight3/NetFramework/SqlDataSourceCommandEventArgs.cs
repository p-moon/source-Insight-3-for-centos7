public class SqlDataSourceCommandEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public SqlDataSourceCommandEventArgs(System.Data.Common.DbCommand command) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Data.Common.DbCommand Command { get{} }
	public bool Cancel { get{} set{} }
}


public class SqlDataSourceStatusEventArgs : System.EventArgs
{

	// Constructors
	public SqlDataSourceStatusEventArgs(System.Data.Common.DbCommand command, int affectedRows, System.Exception exception) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int AffectedRows { get{} }
	public System.Data.Common.DbCommand Command { get{} }
	public System.Exception Exception { get{} }
	public bool ExceptionHandled { get{} set{} }
}


public class OracleRowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs
{

	// Constructors
	public OracleRowUpdatingEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public OracleCommand Command { get{} set{} }
	public System.Data.IDbCommand Command { get{} set{} }
	public System.Exception Errors { get{} set{} }
	public System.Data.DataRow Row { get{} }
	public System.Data.StatementType StatementType { get{} }
	public System.Data.UpdateStatus Status { get{} set{} }
	public System.Data.Common.DataTableMapping TableMapping { get{} }
}


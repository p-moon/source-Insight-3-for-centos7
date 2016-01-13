public class OracleRowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs
{

	// Constructors
	public OracleRowUpdatedEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) {}

	// Methods
	public void CopyToRows(System.Data.DataRow[] array) {}
	public void CopyToRows(System.Data.DataRow[] array, int arrayIndex) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public OracleCommand Command { get{} }
	public System.Data.IDbCommand Command { get{} }
	public System.Exception Errors { get{} set{} }
	public int RecordsAffected { get{} }
	public System.Data.DataRow Row { get{} }
	public int RowCount { get{} }
	public System.Data.StatementType StatementType { get{} }
	public System.Data.UpdateStatus Status { get{} set{} }
	public System.Data.Common.DataTableMapping TableMapping { get{} }
}


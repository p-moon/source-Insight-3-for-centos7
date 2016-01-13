public class DataGridViewDataErrorEventArgs : DataGridViewCellCancelEventArgs
{

	// Constructors
	public DataGridViewDataErrorEventArgs(System.Exception exception, int columnIndex, int rowIndex, DataGridViewDataErrorContexts context) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewDataErrorContexts Context { get{} }
	public System.Exception Exception { get{} }
	public bool ThrowException { get{} set{} }
	public int ColumnIndex { get{} }
	public int RowIndex { get{} }
	public bool Cancel { get{} set{} }
}


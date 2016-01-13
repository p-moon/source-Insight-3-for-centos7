public class DataGridViewCellValidatingEventArgs : System.ComponentModel.CancelEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ColumnIndex { get{} }
	public object FormattedValue { get{} }
	public int RowIndex { get{} }
	public bool Cancel { get{} set{} }
}


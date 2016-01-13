public class DataGridViewCellErrorTextNeededEventArgs : DataGridViewCellEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ErrorText { get{} set{} }
	public int ColumnIndex { get{} }
	public int RowIndex { get{} }
}


public class DataGridViewRowHeightInfoNeededEventArgs : System.EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Height { get{} set{} }
	public int MinimumHeight { get{} set{} }
	public int RowIndex { get{} }
}


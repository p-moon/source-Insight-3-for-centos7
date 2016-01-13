public class DataGridViewRowHeightInfoPushedEventArgs : System.ComponentModel.HandledEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Height { get{} }
	public int MinimumHeight { get{} }
	public int RowIndex { get{} }
	public bool Handled { get{} set{} }
}


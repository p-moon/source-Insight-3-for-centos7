public class ColumnWidthChangingEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public ColumnWidthChangingEventArgs(int columnIndex, int newWidth, bool cancel) {}
	public ColumnWidthChangingEventArgs(int columnIndex, int newWidth) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ColumnIndex { get{} }
	public int NewWidth { get{} set{} }
	public bool Cancel { get{} set{} }
}


public class DataGridViewRowContextMenuStripNeededEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewRowContextMenuStripNeededEventArgs(int rowIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int RowIndex { get{} }
	public ContextMenuStrip ContextMenuStrip { get{} set{} }
}


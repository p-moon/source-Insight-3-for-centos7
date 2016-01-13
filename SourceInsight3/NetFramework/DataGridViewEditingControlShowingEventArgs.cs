public class DataGridViewEditingControlShowingEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewEditingControlShowingEventArgs(Control control, DataGridViewCellStyle cellStyle) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewCellStyle CellStyle { get{} set{} }
	public Control Control { get{} }
}


public class DataGridViewRowCancelEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public DataGridViewRowCancelEventArgs(DataGridViewRow dataGridViewRow) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewRow Row { get{} }
	public bool Cancel { get{} set{} }
}


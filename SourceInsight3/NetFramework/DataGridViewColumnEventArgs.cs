public class DataGridViewColumnEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewColumnEventArgs(DataGridViewColumn dataGridViewColumn) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewColumn Column { get{} }
}


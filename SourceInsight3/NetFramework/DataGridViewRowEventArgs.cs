public class DataGridViewRowEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewRowEventArgs(DataGridViewRow dataGridViewRow) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewRow Row { get{} }
}


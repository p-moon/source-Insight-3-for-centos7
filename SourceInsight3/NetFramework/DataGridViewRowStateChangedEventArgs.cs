public class DataGridViewRowStateChangedEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewRowStateChangedEventArgs(DataGridViewRow dataGridViewRow, DataGridViewElementStates stateChanged) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewRow Row { get{} }
	public DataGridViewElementStates StateChanged { get{} }
}


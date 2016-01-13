public class DataGridViewColumnStateChangedEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewColumnStateChangedEventArgs(DataGridViewColumn dataGridViewColumn, DataGridViewElementStates stateChanged) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewColumn Column { get{} }
	public DataGridViewElementStates StateChanged { get{} }
}


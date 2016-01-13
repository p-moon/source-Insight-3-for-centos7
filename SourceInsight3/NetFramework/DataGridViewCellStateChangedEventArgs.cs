public class DataGridViewCellStateChangedEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewCellStateChangedEventArgs(DataGridViewCell dataGridViewCell, DataGridViewElementStates stateChanged) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewCell Cell { get{} }
	public DataGridViewElementStates StateChanged { get{} }
}


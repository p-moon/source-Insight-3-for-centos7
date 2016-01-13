public class DataGridViewAutoSizeColumnModeEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewAutoSizeColumnModeEventArgs(DataGridViewColumn dataGridViewColumn, DataGridViewAutoSizeColumnMode previousMode) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DataGridViewColumn Column { get{} }
	public DataGridViewAutoSizeColumnMode PreviousMode { get{} }
}


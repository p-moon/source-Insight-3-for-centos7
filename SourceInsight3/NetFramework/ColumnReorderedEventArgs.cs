public class ColumnReorderedEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public ColumnReorderedEventArgs(int oldDisplayIndex, int newDisplayIndex, ColumnHeader header) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int OldDisplayIndex { get{} }
	public int NewDisplayIndex { get{} }
	public ColumnHeader Header { get{} }
	public bool Cancel { get{} set{} }
}


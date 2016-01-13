public class DataGridViewBindingCompleteEventArgs : System.EventArgs
{

	// Constructors
	public DataGridViewBindingCompleteEventArgs(System.ComponentModel.ListChangedType listChangedType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.ComponentModel.ListChangedType ListChangedType { get{} }
}


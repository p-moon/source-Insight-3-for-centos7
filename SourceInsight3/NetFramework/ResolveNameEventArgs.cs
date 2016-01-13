public class ResolveNameEventArgs : System.EventArgs
{

	// Constructors
	public ResolveNameEventArgs(string name) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public object Value { get{} set{} }
}


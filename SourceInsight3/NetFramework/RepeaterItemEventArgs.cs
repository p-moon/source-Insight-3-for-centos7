public class RepeaterItemEventArgs : System.EventArgs
{

	// Constructors
	public RepeaterItemEventArgs(RepeaterItem item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RepeaterItem Item { get{} }
}


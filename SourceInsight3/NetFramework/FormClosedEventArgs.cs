public class FormClosedEventArgs : System.EventArgs
{

	// Constructors
	public FormClosedEventArgs(CloseReason closeReason) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CloseReason CloseReason { get{} }
}


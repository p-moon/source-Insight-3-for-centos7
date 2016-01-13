public class PrintEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public PrintEventArgs() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PrintAction PrintAction { get{} }
	public bool Cancel { get{} set{} }
}


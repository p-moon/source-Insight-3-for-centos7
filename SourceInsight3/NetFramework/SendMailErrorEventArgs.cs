public class SendMailErrorEventArgs : System.EventArgs
{

	// Constructors
	public SendMailErrorEventArgs(System.Exception e) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Exception Exception { get{} set{} }
	public bool Handled { get{} set{} }
}


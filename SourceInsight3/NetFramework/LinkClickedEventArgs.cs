public class LinkClickedEventArgs : System.EventArgs
{

	// Constructors
	public LinkClickedEventArgs(string linkText) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string LinkText { get{} }
}


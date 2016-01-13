public class WebPartVerbsEventArgs : System.EventArgs
{

	// Constructors
	public WebPartVerbsEventArgs() {}
	public WebPartVerbsEventArgs(WebPartVerbCollection verbs) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public WebPartVerbCollection Verbs { get{} set{} }
}


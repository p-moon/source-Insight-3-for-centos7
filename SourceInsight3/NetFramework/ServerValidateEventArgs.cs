public class ServerValidateEventArgs : System.EventArgs
{

	// Constructors
	public ServerValidateEventArgs(string value, bool isValid) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Value { get{} }
	public bool IsValid { get{} set{} }
}


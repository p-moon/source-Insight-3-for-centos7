public class InternalConfigEventArgs : System.EventArgs
{

	// Constructors
	public InternalConfigEventArgs(string configPath) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ConfigPath { get{} set{} }
}


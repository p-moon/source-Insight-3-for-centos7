public class StartupEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public StartupEventArgs(ReadOnlyCollection<string> args) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ReadOnlyCollection<string> CommandLine { get{} }
	public bool Cancel { get{} set{} }
}


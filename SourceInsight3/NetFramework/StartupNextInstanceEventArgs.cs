public class StartupNextInstanceEventArgs : System.EventArgs
{

	// Constructors
	public StartupNextInstanceEventArgs(ReadOnlyCollection<string> args, bool bringToForegroundFlag) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool BringToForeground { get{} set{} }
	public ReadOnlyCollection<string> CommandLine { get{} }
}


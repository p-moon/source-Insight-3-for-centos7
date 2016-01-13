public class UnhandledExceptionEventArgs : System.Threading.ThreadExceptionEventArgs
{

	// Constructors
	public UnhandledExceptionEventArgs(bool exitApplication, System.Exception exception) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool ExitApplication { get{} set{} }
	public System.Exception Exception { get{} }
}


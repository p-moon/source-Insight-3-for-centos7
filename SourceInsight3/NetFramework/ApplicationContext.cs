public class ApplicationContext : System.IDisposable
{

	// Constructors
	public ApplicationContext() {}
	public ApplicationContext(Form mainForm) {}

	// Methods
	public virtual void Dispose() {}
	public void ExitThread() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Form MainForm { get{} set{} }
	public object Tag { get{} set{} }

	// Events
	public event System.EventHandler ThreadExit;
}


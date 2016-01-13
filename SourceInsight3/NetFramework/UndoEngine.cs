public class UndoEngine : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UndoInProgress { get{} }
	public bool Enabled { get{} set{} }

	// Events
	public event System.EventHandler Undoing;
	public event System.EventHandler Undone;
}


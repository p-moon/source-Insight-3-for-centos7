public class QueryContinueDragEventArgs : System.EventArgs
{

	// Constructors
	public QueryContinueDragEventArgs(int keyState, bool escapePressed, DragAction action) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int KeyState { get{} }
	public bool EscapePressed { get{} }
	public DragAction Action { get{} set{} }
}


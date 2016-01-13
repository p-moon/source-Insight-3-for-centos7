public class GiveFeedbackEventArgs : System.EventArgs
{

	// Constructors
	public GiveFeedbackEventArgs(DragDropEffects effect, bool useDefaultCursors) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DragDropEffects Effect { get{} }
	public bool UseDefaultCursors { get{} set{} }
}


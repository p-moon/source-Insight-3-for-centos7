public class ScrollEventArgs : System.EventArgs
{

	// Constructors
	public ScrollEventArgs(ScrollEventType type, int newValue) {}
	public ScrollEventArgs(ScrollEventType type, int newValue, ScrollOrientation scroll) {}
	public ScrollEventArgs(ScrollEventType type, int oldValue, int newValue) {}
	public ScrollEventArgs(ScrollEventType type, int oldValue, int newValue, ScrollOrientation scroll) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ScrollOrientation ScrollOrientation { get{} }
	public ScrollEventType Type { get{} }
	public int NewValue { get{} set{} }
	public int OldValue { get{} }
}


public class ItemDragEventArgs : System.EventArgs
{

	// Constructors
	public ItemDragEventArgs(MouseButtons button) {}
	public ItemDragEventArgs(MouseButtons button, object item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MouseButtons Button { get{} }
	public object Item { get{} }
}


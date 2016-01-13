public class ListViewItemMouseHoverEventArgs : System.EventArgs
{

	// Constructors
	public ListViewItemMouseHoverEventArgs(ListViewItem item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ListViewItem Item { get{} }
}


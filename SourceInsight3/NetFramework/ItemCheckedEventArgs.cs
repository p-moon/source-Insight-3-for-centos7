public class ItemCheckedEventArgs : System.EventArgs
{

	// Constructors
	public ItemCheckedEventArgs(ListViewItem item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ListViewItem Item { get{} }
}


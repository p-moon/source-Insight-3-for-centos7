public class RetrieveVirtualItemEventArgs : System.EventArgs
{

	// Constructors
	public RetrieveVirtualItemEventArgs(int itemIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ItemIndex { get{} }
	public ListViewItem Item { get{} set{} }
}


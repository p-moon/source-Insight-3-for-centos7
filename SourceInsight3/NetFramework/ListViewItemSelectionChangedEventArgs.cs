public class ListViewItemSelectionChangedEventArgs : System.EventArgs
{

	// Constructors
	public ListViewItemSelectionChangedEventArgs(ListViewItem item, int itemIndex, bool isSelected) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsSelected { get{} }
	public ListViewItem Item { get{} }
	public int ItemIndex { get{} }
}


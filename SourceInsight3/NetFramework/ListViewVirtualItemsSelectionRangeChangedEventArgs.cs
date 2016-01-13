public class ListViewVirtualItemsSelectionRangeChangedEventArgs : System.EventArgs
{

	// Constructors
	public ListViewVirtualItemsSelectionRangeChangedEventArgs(int startIndex, int endIndex, bool isSelected) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int EndIndex { get{} }
	public bool IsSelected { get{} }
	public int StartIndex { get{} }
}


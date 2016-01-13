public class ListViewHitTestInfo
{

	// Constructors
	public ListViewHitTestInfo(ListViewItem hitItem, ListViewSubItem hitSubItem, ListViewHitTestLocations hitLocation) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ListViewHitTestLocations Location { get{} }
	public ListViewItem Item { get{} }
	public ListViewSubItem SubItem { get{} }
}


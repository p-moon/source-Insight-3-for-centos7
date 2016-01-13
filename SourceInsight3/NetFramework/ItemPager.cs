public class ItemPager
{

	// Constructors
	public ItemPager() {}
	public ItemPager(ControlPager pager, MobileControl control, int itemCount, int itemsPerPage, int itemWeight) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ItemIndex { get{} }
	public int ItemCount { get{} }
}


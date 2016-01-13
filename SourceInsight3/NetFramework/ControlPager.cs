public class ControlPager
{

	// Constructors
	public ControlPager(Form form, int pageWeight) {}

	// Methods
	public int GetPage(int weight) {}
	public ItemPager GetItemPager(MobileControl control, int itemCount, int itemsPerPage, int itemWeight) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int DefaultWeight;
	public int UseDefaultWeight;

	// Properties
	public int PageWeight { get{} }
	public int RemainingWeight { get{} set{} }
	public int PageCount { get{} set{} }
}


public class ListBoxItem
{

	// Constructors
	public ListBoxItem(string ItemString, int ItemData) {}
	public ListBoxItem(string ItemString) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int ItemData;
	public string ItemString;
}


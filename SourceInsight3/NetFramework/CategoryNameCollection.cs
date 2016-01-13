public class CategoryNameCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CategoryNameCollection(CategoryNameCollection value) {}
	public CategoryNameCollection(string[] value) {}

	// Methods
	public bool Contains(string value) {}
	public void CopyTo(string[] array, int index) {}
	public int IndexOf(string value) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Item { get{} }
	public int Count { get{} }
}


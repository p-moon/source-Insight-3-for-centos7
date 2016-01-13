public class GridItemCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public GridItemCollection Empty;

	// Properties
	public int Count { get{} }
	public GridItem Item { get{} }
	public GridItem Item { get{} }
}


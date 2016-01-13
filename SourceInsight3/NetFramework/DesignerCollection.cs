public class DesignerCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DesignerCollection(IDesignerHost[] designers) {}
	public DesignerCollection(System.Collections.IList designers) {}

	// Methods
	public System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public IDesignerHost Item { get{} }
}


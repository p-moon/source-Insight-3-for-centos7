public class AttributeCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public AttributeCollection(System.Attribute[] attributes) {}

	// Methods
	public static AttributeCollection FromExisting(AttributeCollection existing, System.Attribute[] newAttributes) {}
	public bool Contains(System.Attribute attribute) {}
	public bool Contains(System.Attribute[] attributes) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public bool Matches(System.Attribute attribute) {}
	public bool Matches(System.Attribute[] attributes) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public AttributeCollection Empty;

	// Properties
	public int Count { get{} }
	public System.Attribute Item { get{} }
	public System.Attribute Item { get{} }
}


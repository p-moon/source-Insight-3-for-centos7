public class PropertyCollection : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(string propertyName) {}
	public void CopyTo(PropertyValueCollection[] array, int index) {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PropertyValueCollection Item { get{} }
	public int Count { get{} }
	public System.Collections.ICollection PropertyNames { get{} }
	public System.Collections.ICollection Values { get{} }
}


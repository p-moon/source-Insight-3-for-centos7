public class ResultPropertyCollection : System.Collections.DictionaryBase, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(string propertyName) {}
	public void CopyTo(ResultPropertyValueCollection[] array, int index) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void Clear() {}
	public virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ResultPropertyValueCollection Item { get{} }
	public System.Collections.ICollection PropertyNames { get{} }
	public System.Collections.ICollection Values { get{} }
	public int Count { get{} }
}


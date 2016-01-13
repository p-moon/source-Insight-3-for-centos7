public interface IOrderedDictionary : System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public abstract virtual System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public abstract virtual void Insert(int index, object key, object value) {}
	public abstract virtual void RemoveAt(int index) {}

	// Properties
	public object Item { get{} set{} }
}


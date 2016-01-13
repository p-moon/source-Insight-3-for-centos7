public class CryptographicAttributeObjectCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CryptographicAttributeObjectCollection() {}
	public CryptographicAttributeObjectCollection(CryptographicAttributeObject attribute) {}

	// Methods
	public int Add(AsnEncodedData asnEncodedData) {}
	public int Add(CryptographicAttributeObject attribute) {}
	public void Remove(CryptographicAttributeObject attribute) {}
	public CryptographicAttributeObjectEnumerator GetEnumerator() {}
	public void CopyTo(CryptographicAttributeObject[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CryptographicAttributeObject Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}


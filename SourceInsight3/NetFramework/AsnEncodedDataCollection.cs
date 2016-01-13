public class AsnEncodedDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public AsnEncodedDataCollection() {}
	public AsnEncodedDataCollection(AsnEncodedData asnEncodedData) {}

	// Methods
	public int Add(AsnEncodedData asnEncodedData) {}
	public void Remove(AsnEncodedData asnEncodedData) {}
	public AsnEncodedDataEnumerator GetEnumerator() {}
	public void CopyTo(AsnEncodedData[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AsnEncodedData Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}


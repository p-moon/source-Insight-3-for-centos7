public class PropertyDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public virtual void CopyTo(System.Array array, int index) {}
	public void CopyTo(PropertyData[] propertyArray, int index) {}
	public PropertyDataEnumerator GetEnumerator() {}
	public virtual void Remove(string propertyName) {}
	public virtual void Add(string propertyName, object propertyValue) {}
	public void Add(string propertyName, object propertyValue, CimType propertyType) {}
	public void Add(string propertyName, CimType propertyType, bool isArray) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public PropertyData Item { get{} }
}


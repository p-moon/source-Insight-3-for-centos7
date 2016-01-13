public class CounterCreationDataCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CounterCreationDataCollection() {}
	public CounterCreationDataCollection(CounterCreationDataCollection value) {}
	public CounterCreationDataCollection(CounterCreationData[] value) {}

	// Methods
	public int Add(CounterCreationData value) {}
	public void AddRange(CounterCreationData[] value) {}
	public void AddRange(CounterCreationDataCollection value) {}
	public bool Contains(CounterCreationData value) {}
	public void CopyTo(CounterCreationData[] array, int index) {}
	public int IndexOf(CounterCreationData value) {}
	public void Insert(int index, CounterCreationData value) {}
	public virtual void Remove(CounterCreationData value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CounterCreationData Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


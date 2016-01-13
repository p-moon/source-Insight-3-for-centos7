public class SelectedDatesCollection : System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public SelectedDatesCollection(System.Collections.ArrayList dateList) {}

	// Methods
	public void Add(System.DateTime date) {}
	public void Clear() {}
	public bool Contains(System.DateTime date) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public void Remove(System.DateTime date) {}
	public void SelectRange(System.DateTime fromDate, System.DateTime toDate) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public System.DateTime Item { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
}


public class ProcessThreadCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ProcessThreadCollection(ProcessThread[] processThreads) {}

	// Methods
	public int Add(ProcessThread thread) {}
	public void Insert(int index, ProcessThread thread) {}
	public int IndexOf(ProcessThread thread) {}
	public bool Contains(ProcessThread thread) {}
	public void Remove(ProcessThread thread) {}
	public void CopyTo(ProcessThread[] array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ProcessThread Item { get{} }
	public int Count { get{} }
}


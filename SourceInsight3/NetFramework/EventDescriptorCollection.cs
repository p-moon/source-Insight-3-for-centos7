public class EventDescriptorCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public EventDescriptorCollection(EventDescriptor[] events) {}
	public EventDescriptorCollection(EventDescriptor[] events, bool readOnly) {}

	// Methods
	public int Add(EventDescriptor value) {}
	public void Clear() {}
	public bool Contains(EventDescriptor value) {}
	public virtual EventDescriptor Find(string name, bool ignoreCase) {}
	public int IndexOf(EventDescriptor value) {}
	public void Insert(int index, EventDescriptor value) {}
	public void Remove(EventDescriptor value) {}
	public void RemoveAt(int index) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public virtual EventDescriptorCollection Sort() {}
	public virtual EventDescriptorCollection Sort(string[] names) {}
	public virtual EventDescriptorCollection Sort(string[] names, System.Collections.IComparer comparer) {}
	public virtual EventDescriptorCollection Sort(System.Collections.IComparer comparer) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public EventDescriptorCollection Empty;

	// Properties
	public int Count { get{} }
	public EventDescriptor Item { get{} }
	public EventDescriptor Item { get{} }
}


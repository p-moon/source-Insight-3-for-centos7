public class TraceListenerCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(TraceListener listener) {}
	public void AddRange(TraceListener[] value) {}
	public void AddRange(TraceListenerCollection value) {}
	public virtual void Clear() {}
	public bool Contains(TraceListener listener) {}
	public void CopyTo(TraceListener[] listeners, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(TraceListener listener) {}
	public void Insert(int index, TraceListener listener) {}
	public void Remove(TraceListener listener) {}
	public void Remove(string name) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TraceListener Item { get{} set{} }
	public TraceListener Item { get{} }
	public int Count { get{} }
}


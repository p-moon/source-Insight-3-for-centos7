public class EmptyControlCollection : ControlCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public EmptyControlCollection(Control owner) {}

	// Methods
	public virtual void Add(Control child) {}
	public virtual void AddAt(int index, Control child) {}
	public virtual void Clear() {}
	public virtual bool Contains(Control c) {}
	public virtual int IndexOf(Control value) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual void RemoveAt(int index) {}
	public virtual void Remove(Control value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public object SyncRoot { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public Control Item { get{} }
}


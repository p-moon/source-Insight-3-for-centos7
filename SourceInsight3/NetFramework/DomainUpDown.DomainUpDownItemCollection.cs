public class DomainUpDownItemCollection : System.Collections.ArrayList, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.ICloneable
{

	// Methods
	public virtual int Add(object item) {}
	public virtual void Remove(object item) {}
	public virtual void RemoveAt(int item) {}
	public virtual void Insert(int index, object item) {}
	public virtual void AddRange(System.Collections.ICollection c) {}
	public virtual int BinarySearch(int index, int count, object value, System.Collections.IComparer comparer) {}
	public virtual int BinarySearch(object value) {}
	public virtual int BinarySearch(object value, System.Collections.IComparer comparer) {}
	public virtual void Clear() {}
	public virtual object Clone() {}
	public virtual bool Contains(object item) {}
	public virtual void CopyTo(System.Array array) {}
	public virtual void CopyTo(System.Array array, int arrayIndex) {}
	public virtual void CopyTo(int index, System.Array array, int arrayIndex, int count) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public virtual System.Collections.IEnumerator GetEnumerator(int index, int count) {}
	public virtual int IndexOf(object value) {}
	public virtual int IndexOf(object value, int startIndex) {}
	public virtual int IndexOf(object value, int startIndex, int count) {}
	public virtual void InsertRange(int index, System.Collections.ICollection c) {}
	public virtual int LastIndexOf(object value) {}
	public virtual int LastIndexOf(object value, int startIndex) {}
	public virtual int LastIndexOf(object value, int startIndex, int count) {}
	public virtual void RemoveRange(int index, int count) {}
	public virtual void Reverse() {}
	public virtual void Reverse(int index, int count) {}
	public virtual void SetRange(int index, System.Collections.ICollection c) {}
	public virtual System.Collections.ArrayList GetRange(int index, int count) {}
	public virtual void Sort() {}
	public virtual void Sort(System.Collections.IComparer comparer) {}
	public virtual void Sort(int index, int count, System.Collections.IComparer comparer) {}
	public virtual object[] ToArray() {}
	public virtual System.Array ToArray(Type type) {}
	public virtual void TrimToSize() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
	public bool IsFixedSize { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}


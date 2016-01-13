public class ArrayList : IList, ICollection, IEnumerable, System.ICloneable
{

	// Constructors
	public ArrayList() {}
	public ArrayList(int capacity) {}
	public ArrayList(ICollection c) {}

	// Methods
	public static ArrayList Adapter(IList list) {}
	public virtual int Add(object value) {}
	public virtual void AddRange(ICollection c) {}
	public virtual int BinarySearch(int index, int count, object value, IComparer comparer) {}
	public virtual int BinarySearch(object value) {}
	public virtual int BinarySearch(object value, IComparer comparer) {}
	public virtual void Clear() {}
	public virtual object Clone() {}
	public virtual bool Contains(object item) {}
	public virtual void CopyTo(System.Array array) {}
	public virtual void CopyTo(System.Array array, int arrayIndex) {}
	public virtual void CopyTo(int index, System.Array array, int arrayIndex, int count) {}
	public static IList FixedSize(IList list) {}
	public static ArrayList FixedSize(ArrayList list) {}
	public virtual IEnumerator GetEnumerator() {}
	public virtual IEnumerator GetEnumerator(int index, int count) {}
	public virtual int IndexOf(object value) {}
	public virtual int IndexOf(object value, int startIndex) {}
	public virtual int IndexOf(object value, int startIndex, int count) {}
	public virtual void Insert(int index, object value) {}
	public virtual void InsertRange(int index, ICollection c) {}
	public virtual int LastIndexOf(object value) {}
	public virtual int LastIndexOf(object value, int startIndex) {}
	public virtual int LastIndexOf(object value, int startIndex, int count) {}
	public static IList ReadOnly(IList list) {}
	public static ArrayList ReadOnly(ArrayList list) {}
	public virtual void Remove(object obj) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveRange(int index, int count) {}
	public static ArrayList Repeat(object value, int count) {}
	public virtual void Reverse() {}
	public virtual void Reverse(int index, int count) {}
	public virtual void SetRange(int index, ICollection c) {}
	public virtual ArrayList GetRange(int index, int count) {}
	public virtual void Sort() {}
	public virtual void Sort(IComparer comparer) {}
	public virtual void Sort(int index, int count, IComparer comparer) {}
	public static IList Synchronized(IList list) {}
	public static ArrayList Synchronized(ArrayList list) {}
	public virtual object[] ToArray() {}
	public virtual System.Array ToArray(Type type) {}
	public virtual void TrimToSize() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Capacity { get{} set{} }
	public int Count { get{} }
	public bool IsFixedSize { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
	public object Item { get{} set{} }
}


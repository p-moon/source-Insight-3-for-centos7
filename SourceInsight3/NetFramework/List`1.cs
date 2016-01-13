public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
{

	// Constructors
	public List() {}
	public List(int capacity) {}
	public List(IEnumerable<T> collection) {}

	// Methods
	public List<TOutput> ConvertAll<TOutput>(Converter<T,TOutput> converter) {}
	public virtual void Add(T item) {}
	public void AddRange(IEnumerable<T> collection) {}
	public ReadOnlyCollection<T> AsReadOnly() {}
	public int BinarySearch(int index, int count, T item, IComparer<T> comparer) {}
	public int BinarySearch(T item) {}
	public int BinarySearch(T item, IComparer<T> comparer) {}
	public virtual void Clear() {}
	public virtual bool Contains(T item) {}
	public void CopyTo(T[] array) {}
	public void CopyTo(int index, T[] array, int arrayIndex, int count) {}
	public virtual void CopyTo(T[] array, int arrayIndex) {}
	public bool Exists(Predicate<T> match) {}
	public T Find(Predicate<T> match) {}
	public List<T> FindAll(Predicate<T> match) {}
	public int FindIndex(Predicate<T> match) {}
	public int FindIndex(int startIndex, Predicate<T> match) {}
	public int FindIndex(int startIndex, int count, Predicate<T> match) {}
	public T FindLast(Predicate<T> match) {}
	public int FindLastIndex(Predicate<T> match) {}
	public int FindLastIndex(int startIndex, Predicate<T> match) {}
	public int FindLastIndex(int startIndex, int count, Predicate<T> match) {}
	public void ForEach(Action<T> action) {}
	public Enumerator<T> GetEnumerator() {}
	public List<T> GetRange(int index, int count) {}
	public virtual int IndexOf(T item) {}
	public int IndexOf(T item, int index) {}
	public int IndexOf(T item, int index, int count) {}
	public virtual void Insert(int index, T item) {}
	public void InsertRange(int index, IEnumerable<T> collection) {}
	public int LastIndexOf(T item) {}
	public int LastIndexOf(T item, int index) {}
	public int LastIndexOf(T item, int index, int count) {}
	public virtual bool Remove(T item) {}
	public int RemoveAll(Predicate<T> match) {}
	public virtual void RemoveAt(int index) {}
	public void RemoveRange(int index, int count) {}
	public void Reverse() {}
	public void Reverse(int index, int count) {}
	public void Sort() {}
	public void Sort(IComparer<T> comparer) {}
	public void Sort(int index, int count, IComparer<T> comparer) {}
	public void Sort(Comparison<T> comparison) {}
	public T[] ToArray() {}
	public void TrimExcess() {}
	public bool TrueForAll(Predicate<T> match) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Capacity { get{} set{} }
	public int Count { get{} }
	public T Item { get{} set{} }
}


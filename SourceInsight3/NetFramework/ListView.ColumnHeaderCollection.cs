public class ColumnHeaderCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public ColumnHeaderCollection(ListView owner) {}

	// Methods
	public virtual void RemoveByKey(string key) {}
	public virtual int IndexOfKey(string key) {}
	public virtual ColumnHeader Add(string text, int width, HorizontalAlignment textAlign) {}
	public virtual int Add(ColumnHeader value) {}
	public virtual ColumnHeader Add(string text) {}
	public virtual ColumnHeader Add(string text, int width) {}
	public virtual ColumnHeader Add(string key, string text) {}
	public virtual ColumnHeader Add(string key, string text, int width) {}
	public virtual ColumnHeader Add(string key, string text, int width, HorizontalAlignment textAlign, string imageKey) {}
	public virtual ColumnHeader Add(string key, string text, int width, HorizontalAlignment textAlign, int imageIndex) {}
	public virtual void AddRange(ColumnHeader[] values) {}
	public virtual void Clear() {}
	public bool Contains(ColumnHeader value) {}
	public virtual bool ContainsKey(string key) {}
	public int IndexOf(ColumnHeader value) {}
	public void Insert(int index, ColumnHeader value) {}
	public void Insert(int index, string text, int width, HorizontalAlignment textAlign) {}
	public void Insert(int index, string text) {}
	public void Insert(int index, string text, int width) {}
	public void Insert(int index, string key, string text) {}
	public void Insert(int index, string key, string text, int width) {}
	public void Insert(int index, string key, string text, int width, HorizontalAlignment textAlign, string imageKey) {}
	public void Insert(int index, string key, string text, int width, HorizontalAlignment textAlign, int imageIndex) {}
	public virtual void RemoveAt(int index) {}
	public virtual void Remove(ColumnHeader column) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ColumnHeader Item { get{} }
	public ColumnHeader Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
}


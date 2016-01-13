public class TabPageCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public TabPageCollection(TabControl owner) {}

	// Methods
	public void Add(TabPage value) {}
	public void Add(string text) {}
	public void Add(string key, string text) {}
	public void Add(string key, string text, int imageIndex) {}
	public void Add(string key, string text, string imageKey) {}
	public void AddRange(TabPage[] pages) {}
	public bool Contains(TabPage page) {}
	public virtual bool ContainsKey(string key) {}
	public int IndexOf(TabPage page) {}
	public virtual int IndexOfKey(string key) {}
	public void Insert(int index, TabPage tabPage) {}
	public void Insert(int index, string text) {}
	public void Insert(int index, string key, string text) {}
	public void Insert(int index, string key, string text, int imageIndex) {}
	public void Insert(int index, string key, string text, string imageKey) {}
	public virtual void Clear() {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void Remove(TabPage value) {}
	public virtual void RemoveAt(int index) {}
	public virtual void RemoveByKey(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TabPage Item { get{} set{} }
	public TabPage Item { get{} }
	public int Count { get{} }
	public bool IsReadOnly { get{} }
}


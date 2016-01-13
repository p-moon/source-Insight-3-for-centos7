public class ListViewGroupCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(ListViewGroup group) {}
	public ListViewGroup Add(string key, string headerText) {}
	public void AddRange(ListViewGroup[] groups) {}
	public void AddRange(ListViewGroupCollection groups) {}
	public virtual void Clear() {}
	public bool Contains(ListViewGroup value) {}
	public virtual void CopyTo(System.Array array, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public int IndexOf(ListViewGroup value) {}
	public void Insert(int index, ListViewGroup group) {}
	public void Remove(ListViewGroup group) {}
	public virtual void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public ListViewGroup Item { get{} set{} }
	public ListViewGroup Item { get{} set{} }
}


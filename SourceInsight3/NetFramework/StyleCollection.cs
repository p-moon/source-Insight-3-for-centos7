public class StyleCollection : System.Web.UI.StateManagedCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Methods
	public int Add(Style style) {}
	public bool Contains(Style style) {}
	public void CopyTo(Style[] styleArray, int index) {}
	public int IndexOf(Style style) {}
	public void Insert(int index, Style style) {}
	public void Remove(Style style) {}
	public void RemoveAt(int index) {}
	public void Clear() {}
	public virtual void CopyTo(System.Array array, int index) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public void SetDirty() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Style Item { get{} set{} }
	public int Count { get{} }
}


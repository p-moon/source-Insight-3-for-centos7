public class HotSpotCollection : System.Web.UI.StateManagedCollection, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Web.UI.IStateManager
{

	// Constructors
	public HotSpotCollection() {}

	// Methods
	public int Add(HotSpot spot) {}
	public void Insert(int index, HotSpot spot) {}
	public void Remove(HotSpot spot) {}
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
	public HotSpot Item { get{} }
	public int Count { get{} }
}


public class DesignerRegionCollection : System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DesignerRegionCollection() {}
	public DesignerRegionCollection(ControlDesigner owner) {}

	// Methods
	public int Add(DesignerRegion region) {}
	public void Clear() {}
	public void CopyTo(System.Array array, int index) {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public bool Contains(DesignerRegion region) {}
	public int IndexOf(DesignerRegion region) {}
	public void Insert(int index, DesignerRegion region) {}
	public void Remove(DesignerRegion region) {}
	public void RemoveAt(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Count { get{} }
	public bool IsFixedSize { get{} }
	public bool IsReadOnly { get{} }
	public bool IsSynchronized { get{} }
	public ControlDesigner Owner { get{} }
	public object SyncRoot { get{} }
	public DesignerRegion Item { get{} set{} }
}


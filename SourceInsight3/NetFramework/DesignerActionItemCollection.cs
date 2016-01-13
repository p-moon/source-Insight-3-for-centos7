public class DesignerActionItemCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DesignerActionItemCollection() {}

	// Methods
	public int Add(DesignerActionItem value) {}
	public bool Contains(DesignerActionItem value) {}
	public void CopyTo(DesignerActionItem[] array, int index) {}
	public int IndexOf(DesignerActionItem value) {}
	public void Insert(int index, DesignerActionItem value) {}
	public void Remove(DesignerActionItem value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerActionItem Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


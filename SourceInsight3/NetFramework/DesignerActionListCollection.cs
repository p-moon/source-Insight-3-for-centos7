public class DesignerActionListCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DesignerActionListCollection() {}
	public DesignerActionListCollection(DesignerActionList[] value) {}

	// Methods
	public int Add(DesignerActionList value) {}
	public void AddRange(DesignerActionList[] value) {}
	public void AddRange(DesignerActionListCollection value) {}
	public void Insert(int index, DesignerActionList value) {}
	public int IndexOf(DesignerActionList value) {}
	public bool Contains(DesignerActionList value) {}
	public void Remove(DesignerActionList value) {}
	public void CopyTo(DesignerActionList[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerActionList Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


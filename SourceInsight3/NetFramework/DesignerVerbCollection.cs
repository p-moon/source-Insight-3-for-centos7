public class DesignerVerbCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public DesignerVerbCollection() {}
	public DesignerVerbCollection(DesignerVerb[] value) {}

	// Methods
	public int Add(DesignerVerb value) {}
	public void AddRange(DesignerVerb[] value) {}
	public void AddRange(DesignerVerbCollection value) {}
	public void Insert(int index, DesignerVerb value) {}
	public int IndexOf(DesignerVerb value) {}
	public bool Contains(DesignerVerb value) {}
	public void Remove(DesignerVerb value) {}
	public void CopyTo(DesignerVerb[] array, int index) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerVerb Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


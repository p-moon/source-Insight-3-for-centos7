public class CodeNamespaceCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeNamespaceCollection() {}
	public CodeNamespaceCollection(CodeNamespaceCollection value) {}
	public CodeNamespaceCollection(CodeNamespace[] value) {}

	// Methods
	public int Add(CodeNamespace value) {}
	public void AddRange(CodeNamespace[] value) {}
	public void AddRange(CodeNamespaceCollection value) {}
	public bool Contains(CodeNamespace value) {}
	public void CopyTo(CodeNamespace[] array, int index) {}
	public int IndexOf(CodeNamespace value) {}
	public void Insert(int index, CodeNamespace value) {}
	public void Remove(CodeNamespace value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeNamespace Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


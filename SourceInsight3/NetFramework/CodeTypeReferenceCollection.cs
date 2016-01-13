public class CodeTypeReferenceCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeTypeReferenceCollection() {}
	public CodeTypeReferenceCollection(CodeTypeReferenceCollection value) {}
	public CodeTypeReferenceCollection(CodeTypeReference[] value) {}

	// Methods
	public int Add(CodeTypeReference value) {}
	public void Add(string value) {}
	public void Add(Type value) {}
	public void AddRange(CodeTypeReference[] value) {}
	public void AddRange(CodeTypeReferenceCollection value) {}
	public bool Contains(CodeTypeReference value) {}
	public void CopyTo(CodeTypeReference[] array, int index) {}
	public int IndexOf(CodeTypeReference value) {}
	public void Insert(int index, CodeTypeReference value) {}
	public void Remove(CodeTypeReference value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeReference Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


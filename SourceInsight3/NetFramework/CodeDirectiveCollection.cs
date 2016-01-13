public class CodeDirectiveCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeDirectiveCollection() {}
	public CodeDirectiveCollection(CodeDirectiveCollection value) {}
	public CodeDirectiveCollection(CodeDirective[] value) {}

	// Methods
	public int Add(CodeDirective value) {}
	public void AddRange(CodeDirective[] value) {}
	public void AddRange(CodeDirectiveCollection value) {}
	public bool Contains(CodeDirective value) {}
	public void CopyTo(CodeDirective[] array, int index) {}
	public int IndexOf(CodeDirective value) {}
	public void Insert(int index, CodeDirective value) {}
	public void Remove(CodeDirective value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeDirective Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


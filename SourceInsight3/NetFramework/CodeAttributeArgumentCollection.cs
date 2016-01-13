public class CodeAttributeArgumentCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeAttributeArgumentCollection() {}
	public CodeAttributeArgumentCollection(CodeAttributeArgumentCollection value) {}
	public CodeAttributeArgumentCollection(CodeAttributeArgument[] value) {}

	// Methods
	public int Add(CodeAttributeArgument value) {}
	public void AddRange(CodeAttributeArgument[] value) {}
	public void AddRange(CodeAttributeArgumentCollection value) {}
	public bool Contains(CodeAttributeArgument value) {}
	public void CopyTo(CodeAttributeArgument[] array, int index) {}
	public int IndexOf(CodeAttributeArgument value) {}
	public void Insert(int index, CodeAttributeArgument value) {}
	public void Remove(CodeAttributeArgument value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeAttributeArgument Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


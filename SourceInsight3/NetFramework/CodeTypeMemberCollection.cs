public class CodeTypeMemberCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeTypeMemberCollection() {}
	public CodeTypeMemberCollection(CodeTypeMemberCollection value) {}
	public CodeTypeMemberCollection(CodeTypeMember[] value) {}

	// Methods
	public int Add(CodeTypeMember value) {}
	public void AddRange(CodeTypeMember[] value) {}
	public void AddRange(CodeTypeMemberCollection value) {}
	public bool Contains(CodeTypeMember value) {}
	public void CopyTo(CodeTypeMember[] array, int index) {}
	public int IndexOf(CodeTypeMember value) {}
	public void Insert(int index, CodeTypeMember value) {}
	public void Remove(CodeTypeMember value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeMember Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


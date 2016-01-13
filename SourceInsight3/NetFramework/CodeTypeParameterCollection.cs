public class CodeTypeParameterCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeTypeParameterCollection() {}
	public CodeTypeParameterCollection(CodeTypeParameterCollection value) {}
	public CodeTypeParameterCollection(CodeTypeParameter[] value) {}

	// Methods
	public int Add(CodeTypeParameter value) {}
	public void Add(string value) {}
	public void AddRange(CodeTypeParameter[] value) {}
	public void AddRange(CodeTypeParameterCollection value) {}
	public bool Contains(CodeTypeParameter value) {}
	public void CopyTo(CodeTypeParameter[] array, int index) {}
	public int IndexOf(CodeTypeParameter value) {}
	public void Insert(int index, CodeTypeParameter value) {}
	public void Remove(CodeTypeParameter value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeParameter Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


public class CodeStatementCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeStatementCollection() {}
	public CodeStatementCollection(CodeStatementCollection value) {}
	public CodeStatementCollection(CodeStatement[] value) {}

	// Methods
	public int Add(CodeStatement value) {}
	public int Add(CodeExpression value) {}
	public void AddRange(CodeStatement[] value) {}
	public void AddRange(CodeStatementCollection value) {}
	public bool Contains(CodeStatement value) {}
	public void CopyTo(CodeStatement[] array, int index) {}
	public int IndexOf(CodeStatement value) {}
	public void Insert(int index, CodeStatement value) {}
	public void Remove(CodeStatement value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeStatement Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


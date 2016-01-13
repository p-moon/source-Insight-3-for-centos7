public class CodeExpressionCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeExpressionCollection() {}
	public CodeExpressionCollection(CodeExpressionCollection value) {}
	public CodeExpressionCollection(CodeExpression[] value) {}

	// Methods
	public int Add(CodeExpression value) {}
	public void AddRange(CodeExpression[] value) {}
	public void AddRange(CodeExpressionCollection value) {}
	public bool Contains(CodeExpression value) {}
	public void CopyTo(CodeExpression[] array, int index) {}
	public int IndexOf(CodeExpression value) {}
	public void Insert(int index, CodeExpression value) {}
	public void Remove(CodeExpression value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeExpression Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


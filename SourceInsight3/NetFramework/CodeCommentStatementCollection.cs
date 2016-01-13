public class CodeCommentStatementCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeCommentStatementCollection() {}
	public CodeCommentStatementCollection(CodeCommentStatementCollection value) {}
	public CodeCommentStatementCollection(CodeCommentStatement[] value) {}

	// Methods
	public int Add(CodeCommentStatement value) {}
	public void AddRange(CodeCommentStatement[] value) {}
	public void AddRange(CodeCommentStatementCollection value) {}
	public bool Contains(CodeCommentStatement value) {}
	public void CopyTo(CodeCommentStatement[] array, int index) {}
	public int IndexOf(CodeCommentStatement value) {}
	public void Insert(int index, CodeCommentStatement value) {}
	public void Remove(CodeCommentStatement value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeCommentStatement Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


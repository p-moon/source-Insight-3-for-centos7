public class CodeCatchClauseCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeCatchClauseCollection() {}
	public CodeCatchClauseCollection(CodeCatchClauseCollection value) {}
	public CodeCatchClauseCollection(CodeCatchClause[] value) {}

	// Methods
	public int Add(CodeCatchClause value) {}
	public void AddRange(CodeCatchClause[] value) {}
	public void AddRange(CodeCatchClauseCollection value) {}
	public bool Contains(CodeCatchClause value) {}
	public void CopyTo(CodeCatchClause[] array, int index) {}
	public int IndexOf(CodeCatchClause value) {}
	public void Insert(int index, CodeCatchClause value) {}
	public void Remove(CodeCatchClause value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeCatchClause Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


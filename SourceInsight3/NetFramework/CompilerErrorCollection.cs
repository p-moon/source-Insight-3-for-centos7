public class CompilerErrorCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CompilerErrorCollection() {}
	public CompilerErrorCollection(CompilerErrorCollection value) {}
	public CompilerErrorCollection(CompilerError[] value) {}

	// Methods
	public int Add(CompilerError value) {}
	public void AddRange(CompilerError[] value) {}
	public void AddRange(CompilerErrorCollection value) {}
	public bool Contains(CompilerError value) {}
	public void CopyTo(CompilerError[] array, int index) {}
	public int IndexOf(CompilerError value) {}
	public void Insert(int index, CompilerError value) {}
	public void Remove(CompilerError value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CompilerError Item { get{} set{} }
	public bool HasErrors { get{} }
	public bool HasWarnings { get{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


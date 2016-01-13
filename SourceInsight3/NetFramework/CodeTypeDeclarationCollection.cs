public class CodeTypeDeclarationCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeTypeDeclarationCollection() {}
	public CodeTypeDeclarationCollection(CodeTypeDeclarationCollection value) {}
	public CodeTypeDeclarationCollection(CodeTypeDeclaration[] value) {}

	// Methods
	public int Add(CodeTypeDeclaration value) {}
	public void AddRange(CodeTypeDeclaration[] value) {}
	public void AddRange(CodeTypeDeclarationCollection value) {}
	public bool Contains(CodeTypeDeclaration value) {}
	public void CopyTo(CodeTypeDeclaration[] array, int index) {}
	public int IndexOf(CodeTypeDeclaration value) {}
	public void Insert(int index, CodeTypeDeclaration value) {}
	public void Remove(CodeTypeDeclaration value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeTypeDeclaration Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


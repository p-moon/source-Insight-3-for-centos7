public class CodeAttributeDeclarationCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeAttributeDeclarationCollection() {}
	public CodeAttributeDeclarationCollection(CodeAttributeDeclarationCollection value) {}
	public CodeAttributeDeclarationCollection(CodeAttributeDeclaration[] value) {}

	// Methods
	public int Add(CodeAttributeDeclaration value) {}
	public void AddRange(CodeAttributeDeclaration[] value) {}
	public void AddRange(CodeAttributeDeclarationCollection value) {}
	public bool Contains(CodeAttributeDeclaration value) {}
	public void CopyTo(CodeAttributeDeclaration[] array, int index) {}
	public int IndexOf(CodeAttributeDeclaration value) {}
	public void Insert(int index, CodeAttributeDeclaration value) {}
	public void Remove(CodeAttributeDeclaration value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeAttributeDeclaration Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


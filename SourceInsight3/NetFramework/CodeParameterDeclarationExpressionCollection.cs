public class CodeParameterDeclarationExpressionCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public CodeParameterDeclarationExpressionCollection() {}
	public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpressionCollection value) {}
	public CodeParameterDeclarationExpressionCollection(CodeParameterDeclarationExpression[] value) {}

	// Methods
	public int Add(CodeParameterDeclarationExpression value) {}
	public void AddRange(CodeParameterDeclarationExpression[] value) {}
	public void AddRange(CodeParameterDeclarationExpressionCollection value) {}
	public bool Contains(CodeParameterDeclarationExpression value) {}
	public void CopyTo(CodeParameterDeclarationExpression[] array, int index) {}
	public int IndexOf(CodeParameterDeclarationExpression value) {}
	public void Insert(int index, CodeParameterDeclarationExpression value) {}
	public void Remove(CodeParameterDeclarationExpression value) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public CodeParameterDeclarationExpression Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


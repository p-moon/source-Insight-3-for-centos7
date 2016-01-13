public class ObjectStatementCollection : System.Collections.IEnumerable
{

	// Methods
	public bool ContainsKey(object statementOwner) {}
	public System.Collections.IDictionaryEnumerator GetEnumerator() {}
	public void Populate(System.Collections.ICollection statementOwners) {}
	public void Populate(object owner) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.CodeDom.CodeStatementCollection Item { get{} }
}


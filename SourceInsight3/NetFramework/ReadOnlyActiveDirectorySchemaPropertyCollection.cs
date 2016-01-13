public class ReadOnlyActiveDirectorySchemaPropertyCollection : System.Collections.ReadOnlyCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public bool Contains(ActiveDirectorySchemaProperty schemaProperty) {}
	public int IndexOf(ActiveDirectorySchemaProperty schemaProperty) {}
	public void CopyTo(ActiveDirectorySchemaProperty[] properties, int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectorySchemaProperty Item { get{} }
	public int Count { get{} }
}


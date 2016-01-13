public class ActiveDirectorySchemaPropertyCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(ActiveDirectorySchemaProperty schemaProperty) {}
	public void AddRange(ActiveDirectorySchemaProperty[] properties) {}
	public void AddRange(ActiveDirectorySchemaPropertyCollection properties) {}
	public void AddRange(ReadOnlyActiveDirectorySchemaPropertyCollection properties) {}
	public void Remove(ActiveDirectorySchemaProperty schemaProperty) {}
	public void Insert(int index, ActiveDirectorySchemaProperty schemaProperty) {}
	public bool Contains(ActiveDirectorySchemaProperty schemaProperty) {}
	public void CopyTo(ActiveDirectorySchemaProperty[] properties, int index) {}
	public int IndexOf(ActiveDirectorySchemaProperty schemaProperty) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectorySchemaProperty Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


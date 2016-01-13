public class ActiveDirectorySchemaClassCollection : System.Collections.CollectionBase, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Methods
	public int Add(ActiveDirectorySchemaClass schemaClass) {}
	public void AddRange(ActiveDirectorySchemaClass[] schemaClasses) {}
	public void AddRange(ActiveDirectorySchemaClassCollection schemaClasses) {}
	public void AddRange(ReadOnlyActiveDirectorySchemaClassCollection schemaClasses) {}
	public void Remove(ActiveDirectorySchemaClass schemaClass) {}
	public void Insert(int index, ActiveDirectorySchemaClass schemaClass) {}
	public bool Contains(ActiveDirectorySchemaClass schemaClass) {}
	public void CopyTo(ActiveDirectorySchemaClass[] schemaClasses, int index) {}
	public int IndexOf(ActiveDirectorySchemaClass schemaClass) {}
	public virtual void Clear() {}
	public virtual void RemoveAt(int index) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ActiveDirectorySchemaClass Item { get{} set{} }
	public int Capacity { get{} set{} }
	public int Count { get{} }
}


public class DirectoryEntries : System.Collections.IEnumerable
{

	// Methods
	public DirectoryEntry Add(string name, string schemaClassName) {}
	public DirectoryEntry Find(string name) {}
	public DirectoryEntry Find(string name, string schemaClassName) {}
	public void Remove(DirectoryEntry entry) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SchemaNameCollection SchemaFilter { get{} }
}


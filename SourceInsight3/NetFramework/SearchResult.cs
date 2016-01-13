public class SearchResult
{

	// Methods
	public DirectoryEntry GetDirectoryEntry() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Path { get{} }
	public ResultPropertyCollection Properties { get{} }
}


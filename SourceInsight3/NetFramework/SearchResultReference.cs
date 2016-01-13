public class SearchResultReference
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Uri[] Reference { get{} }
	public DirectoryControl[] Controls { get{} }
}


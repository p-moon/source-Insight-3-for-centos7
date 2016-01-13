public class DirectoryContext
{

	// Constructors
	public DirectoryContext(DirectoryContextType contextType) {}
	public DirectoryContext(DirectoryContextType contextType, string name) {}
	public DirectoryContext(DirectoryContextType contextType, string username, string password) {}
	public DirectoryContext(DirectoryContextType contextType, string name, string username, string password) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string UserName { get{} }
	public DirectoryContextType ContextType { get{} }
}


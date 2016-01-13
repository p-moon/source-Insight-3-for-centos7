public class ComponentRenameEventArgs : System.EventArgs
{

	// Constructors
	public ComponentRenameEventArgs(object component, string oldName, string newName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Component { get{} }
	public string OldName { get{} }
	public string NewName { get{} }
}


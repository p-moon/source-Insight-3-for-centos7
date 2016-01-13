public class TypeEntry
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TypeName { get{} set{} }
	public string AssemblyName { get{} set{} }
}


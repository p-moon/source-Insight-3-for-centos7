public class DesignerDataTableBase
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.ICollection Columns { get{} }
	public string Name { get{} }
	public string Owner { get{} }
}


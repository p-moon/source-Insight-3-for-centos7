public class AssemblyTitleAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public AssemblyTitleAttribute(string title) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Title { get{} }
	public object TypeId { get{} }
}


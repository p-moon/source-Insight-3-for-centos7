public class AssemblyInformationalVersionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public AssemblyInformationalVersionAttribute(string informationalVersion) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string InformationalVersion { get{} }
	public object TypeId { get{} }
}


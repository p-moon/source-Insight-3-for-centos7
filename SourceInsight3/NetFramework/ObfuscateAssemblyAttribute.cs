public class ObfuscateAssemblyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ObfuscateAssemblyAttribute(bool assemblyIsPrivate) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool AssemblyIsPrivate { get{} }
	public bool StripAfterObfuscation { get{} set{} }
	public object TypeId { get{} }
}


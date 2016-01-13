public class InstallerTypeAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public InstallerTypeAttribute(Type installerType) {}
	public InstallerTypeAttribute(string typeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type InstallerType { get{} }
	public object TypeId { get{} }
}


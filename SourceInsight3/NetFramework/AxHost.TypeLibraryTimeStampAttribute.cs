public class TypeLibraryTimeStampAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public TypeLibraryTimeStampAttribute(string timestamp) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.DateTime Value { get{} }
	public object TypeId { get{} }
}


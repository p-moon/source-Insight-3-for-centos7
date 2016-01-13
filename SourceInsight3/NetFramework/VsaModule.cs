public class VsaModule : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public VsaModule(bool bIsVsaModule) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool IsVsaModule { get{} set{} }
	public object TypeId { get{} }
}


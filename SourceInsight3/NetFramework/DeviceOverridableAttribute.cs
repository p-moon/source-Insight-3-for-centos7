public class DeviceOverridableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DeviceOverridableAttribute() {}
	public DeviceOverridableAttribute(bool overridable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Overridable { get{} }
	public object TypeId { get{} }
}


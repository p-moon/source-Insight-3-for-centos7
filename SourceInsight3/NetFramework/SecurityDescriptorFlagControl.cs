public class SecurityDescriptorFlagControl : DirectoryControl
{

	// Constructors
	public SecurityDescriptorFlagControl() {}
	public SecurityDescriptorFlagControl(SecurityMasks masks) {}

	// Methods
	public virtual byte[] GetValue() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public SecurityMasks SecurityMasks { get{} set{} }
	public string Type { get{} }
	public bool IsCritical { get{} set{} }
	public bool ServerSide { get{} set{} }
}


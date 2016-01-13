public class ApplicationAccessControlAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public ApplicationAccessControlAttribute() {}
	public ApplicationAccessControlAttribute(bool val) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool Value { get{} set{} }
	public AccessChecksLevelOption AccessChecksLevel { get{} set{} }
	public AuthenticationOption Authentication { get{} set{} }
	public ImpersonationLevelOption ImpersonationLevel { get{} set{} }
	public object TypeId { get{} }
}


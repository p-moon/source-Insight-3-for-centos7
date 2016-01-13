public class ApplicationActivationAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, IConfigurationAttribute
{

	// Constructors
	public ApplicationActivationAttribute(ActivationOption opt) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ActivationOption Value { get{} }
	public string SoapVRoot { get{} set{} }
	public string SoapMailbox { get{} set{} }
	public object TypeId { get{} }
}


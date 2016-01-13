public class ConfigurationValidatorAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ConfigurationValidatorAttribute(Type validator) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ConfigurationValidatorBase ValidatorInstance { get{} }
	public Type ValidatorType { get{} }
	public object TypeId { get{} }
}


public class CallbackValidatorAttribute : ConfigurationValidatorAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public CallbackValidatorAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ConfigurationValidatorBase ValidatorInstance { get{} }
	public Type Type { get{} set{} }
	public string CallbackMethodName { get{} set{} }
	public Type ValidatorType { get{} }
	public object TypeId { get{} }
}


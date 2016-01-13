public class RegexStringValidatorAttribute : ConfigurationValidatorAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public RegexStringValidatorAttribute(string regex) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ConfigurationValidatorBase ValidatorInstance { get{} }
	public string Regex { get{} }
	public Type ValidatorType { get{} }
	public object TypeId { get{} }
}


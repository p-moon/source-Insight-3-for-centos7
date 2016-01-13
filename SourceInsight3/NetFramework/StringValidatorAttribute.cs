public class StringValidatorAttribute : ConfigurationValidatorAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public StringValidatorAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ConfigurationValidatorBase ValidatorInstance { get{} }
	public int MinLength { get{} set{} }
	public int MaxLength { get{} set{} }
	public string InvalidCharacters { get{} set{} }
	public Type ValidatorType { get{} }
	public object TypeId { get{} }
}


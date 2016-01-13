public class IntegerValidatorAttribute : ConfigurationValidatorAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public IntegerValidatorAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ConfigurationValidatorBase ValidatorInstance { get{} }
	public int MinValue { get{} set{} }
	public int MaxValue { get{} set{} }
	public bool ExcludeRange { get{} set{} }
	public Type ValidatorType { get{} }
	public object TypeId { get{} }
}


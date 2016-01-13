public class LongValidatorAttribute : ConfigurationValidatorAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public LongValidatorAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ConfigurationValidatorBase ValidatorInstance { get{} }
	public long MinValue { get{} set{} }
	public long MaxValue { get{} set{} }
	public bool ExcludeRange { get{} set{} }
	public Type ValidatorType { get{} }
	public object TypeId { get{} }
}


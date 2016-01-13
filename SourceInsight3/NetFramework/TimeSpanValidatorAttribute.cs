public class TimeSpanValidatorAttribute : ConfigurationValidatorAttribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public TimeSpanValidatorAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public string TimeSpanMinValue;
	public string TimeSpanMaxValue;

	// Properties
	public ConfigurationValidatorBase ValidatorInstance { get{} }
	public System.TimeSpan MinValue { get{} }
	public System.TimeSpan MaxValue { get{} }
	public string MinValueString { get{} set{} }
	public string MaxValueString { get{} set{} }
	public bool ExcludeRange { get{} set{} }
	public Type ValidatorType { get{} }
	public object TypeId { get{} }
}


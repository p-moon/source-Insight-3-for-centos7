public class IntegerValidator : ConfigurationValidatorBase
{

	// Constructors
	public IntegerValidator(int minValue, int maxValue) {}
	public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive) {}
	public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive, int resolution) {}

	// Methods
	public virtual bool CanValidate(Type type) {}
	public virtual void Validate(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


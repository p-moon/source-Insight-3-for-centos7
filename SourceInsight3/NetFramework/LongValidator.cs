public class LongValidator : ConfigurationValidatorBase
{

	// Constructors
	public LongValidator(long minValue, long maxValue) {}
	public LongValidator(long minValue, long maxValue, bool rangeIsExclusive) {}
	public LongValidator(long minValue, long maxValue, bool rangeIsExclusive, long resolution) {}

	// Methods
	public virtual bool CanValidate(Type type) {}
	public virtual void Validate(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


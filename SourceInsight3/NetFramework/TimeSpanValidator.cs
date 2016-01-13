public class TimeSpanValidator : ConfigurationValidatorBase
{

	// Constructors
	public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue) {}
	public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue, bool rangeIsExclusive) {}
	public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue, bool rangeIsExclusive, long resolutionInSeconds) {}

	// Methods
	public virtual bool CanValidate(Type type) {}
	public virtual void Validate(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


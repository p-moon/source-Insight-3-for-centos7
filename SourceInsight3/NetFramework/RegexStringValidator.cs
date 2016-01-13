public class RegexStringValidator : ConfigurationValidatorBase
{

	// Constructors
	public RegexStringValidator(string regex) {}

	// Methods
	public virtual bool CanValidate(Type type) {}
	public virtual void Validate(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


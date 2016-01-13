public class StringValidator : ConfigurationValidatorBase
{

	// Constructors
	public StringValidator(int minLength) {}
	public StringValidator(int minLength, int maxLength) {}
	public StringValidator(int minLength, int maxLength, string invalidCharacters) {}

	// Methods
	public virtual bool CanValidate(Type type) {}
	public virtual void Validate(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


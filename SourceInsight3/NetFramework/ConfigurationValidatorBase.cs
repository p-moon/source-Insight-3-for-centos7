public class ConfigurationValidatorBase
{

	// Methods
	public virtual bool CanValidate(Type type) {}
	public abstract virtual void Validate(object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


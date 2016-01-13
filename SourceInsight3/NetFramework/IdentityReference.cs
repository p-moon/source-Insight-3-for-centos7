public class IdentityReference
{

	// Methods
	public abstract virtual bool IsValidTargetType(Type targetType) {}
	public abstract virtual IdentityReference Translate(Type targetType) {}
	public abstract virtual bool Equals(object o) {}
	public abstract virtual int GetHashCode() {}
	public abstract virtual string ToString() {}
	public static bool op_Equality(IdentityReference left, IdentityReference right) {}
	public static bool op_Inequality(IdentityReference left, IdentityReference right) {}
	public Type GetType() {}

	// Properties
	public string Value { get{} }
}


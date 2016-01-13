public class NTAccount : IdentityReference
{

	// Constructors
	public NTAccount(string domainName, string accountName) {}
	public NTAccount(string name) {}

	// Methods
	public virtual bool IsValidTargetType(Type targetType) {}
	public virtual IdentityReference Translate(Type targetType) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public static bool op_Equality(NTAccount left, NTAccount right) {}
	public static bool op_Inequality(NTAccount left, NTAccount right) {}
	public Type GetType() {}

	// Properties
	public string Value { get{} }
}


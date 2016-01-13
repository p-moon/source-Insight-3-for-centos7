public class ExplicitAccess : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int grfAccessPermissions;
	public int grfAccessMode;
	public int grfInheritance;
	public System.IntPtr pMultipleTrustees;
	public int MultipleTrusteeOperation;
	public int TrusteeForm;
	public int TrusteeType;
	public System.IntPtr data;
}


public class SecurityPermissionFlag : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public SecurityPermissionFlag NoFlags;
	public SecurityPermissionFlag Assertion;
	public SecurityPermissionFlag UnmanagedCode;
	public SecurityPermissionFlag SkipVerification;
	public SecurityPermissionFlag Execution;
	public SecurityPermissionFlag ControlThread;
	public SecurityPermissionFlag ControlEvidence;
	public SecurityPermissionFlag ControlPolicy;
	public SecurityPermissionFlag SerializationFormatter;
	public SecurityPermissionFlag ControlDomainPolicy;
	public SecurityPermissionFlag ControlPrincipal;
	public SecurityPermissionFlag ControlAppDomain;
	public SecurityPermissionFlag RemotingConfiguration;
	public SecurityPermissionFlag Infrastructure;
	public SecurityPermissionFlag BindingRedirects;
	public SecurityPermissionFlag AllFlags;
}


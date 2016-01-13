public class MembershipCreateStatus : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public MembershipCreateStatus Success;
	public MembershipCreateStatus InvalidUserName;
	public MembershipCreateStatus InvalidPassword;
	public MembershipCreateStatus InvalidQuestion;
	public MembershipCreateStatus InvalidAnswer;
	public MembershipCreateStatus InvalidEmail;
	public MembershipCreateStatus DuplicateUserName;
	public MembershipCreateStatus DuplicateEmail;
	public MembershipCreateStatus UserRejected;
	public MembershipCreateStatus InvalidProviderUserKey;
	public MembershipCreateStatus DuplicateProviderUserKey;
	public MembershipCreateStatus ProviderError;
}


public class ResultCode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ResultCode Success;
	public ResultCode OperationsError;
	public ResultCode ProtocolError;
	public ResultCode TimeLimitExceeded;
	public ResultCode SizeLimitExceeded;
	public ResultCode CompareFalse;
	public ResultCode CompareTrue;
	public ResultCode AuthMethodNotSupported;
	public ResultCode StrongAuthRequired;
	public ResultCode ReferralV2;
	public ResultCode Referral;
	public ResultCode AdminLimitExceeded;
	public ResultCode UnavailableCriticalExtension;
	public ResultCode ConfidentialityRequired;
	public ResultCode SaslBindInProgress;
	public ResultCode NoSuchAttribute;
	public ResultCode UndefinedAttributeType;
	public ResultCode InappropriateMatching;
	public ResultCode ConstraintViolation;
	public ResultCode AttributeOrValueExists;
	public ResultCode InvalidAttributeSyntax;
	public ResultCode NoSuchObject;
	public ResultCode AliasProblem;
	public ResultCode InvalidDNSyntax;
	public ResultCode AliasDereferencingProblem;
	public ResultCode InappropriateAuthentication;
	public ResultCode InsufficientAccessRights;
	public ResultCode Busy;
	public ResultCode Unavailable;
	public ResultCode UnwillingToPerform;
	public ResultCode LoopDetect;
	public ResultCode SortControlMissing;
	public ResultCode OffsetRangeError;
	public ResultCode NamingViolation;
	public ResultCode ObjectClassViolation;
	public ResultCode NotAllowedOnNonLeaf;
	public ResultCode NotAllowedOnRdn;
	public ResultCode EntryAlreadyExists;
	public ResultCode ObjectClassModificationsProhibited;
	public ResultCode ResultsTooLarge;
	public ResultCode AffectsMultipleDsas;
	public ResultCode VirtualListViewError;
	public ResultCode Other;
}


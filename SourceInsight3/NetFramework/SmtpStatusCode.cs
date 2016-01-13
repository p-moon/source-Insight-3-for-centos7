public class SmtpStatusCode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public SmtpStatusCode SystemStatus;
	public SmtpStatusCode HelpMessage;
	public SmtpStatusCode ServiceReady;
	public SmtpStatusCode ServiceClosingTransmissionChannel;
	public SmtpStatusCode Ok;
	public SmtpStatusCode UserNotLocalWillForward;
	public SmtpStatusCode CannotVerifyUserWillAttemptDelivery;
	public SmtpStatusCode StartMailInput;
	public SmtpStatusCode ServiceNotAvailable;
	public SmtpStatusCode MailboxBusy;
	public SmtpStatusCode LocalErrorInProcessing;
	public SmtpStatusCode InsufficientStorage;
	public SmtpStatusCode ClientNotPermitted;
	public SmtpStatusCode CommandUnrecognized;
	public SmtpStatusCode SyntaxError;
	public SmtpStatusCode CommandNotImplemented;
	public SmtpStatusCode BadCommandSequence;
	public SmtpStatusCode MustIssueStartTlsFirst;
	public SmtpStatusCode CommandParameterNotImplemented;
	public SmtpStatusCode MailboxUnavailable;
	public SmtpStatusCode UserNotLocalTryAlternatePath;
	public SmtpStatusCode ExceededStorageAllocation;
	public SmtpStatusCode MailboxNameNotAllowed;
	public SmtpStatusCode TransactionFailed;
	public SmtpStatusCode GeneralFailure;
}


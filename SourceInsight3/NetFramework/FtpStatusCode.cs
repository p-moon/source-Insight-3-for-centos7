public class FtpStatusCode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public FtpStatusCode Undefined;
	public FtpStatusCode RestartMarker;
	public FtpStatusCode ServiceTemporarilyNotAvailable;
	public FtpStatusCode DataAlreadyOpen;
	public FtpStatusCode OpeningData;
	public FtpStatusCode CommandOK;
	public FtpStatusCode CommandExtraneous;
	public FtpStatusCode DirectoryStatus;
	public FtpStatusCode FileStatus;
	public FtpStatusCode SystemType;
	public FtpStatusCode SendUserCommand;
	public FtpStatusCode ClosingControl;
	public FtpStatusCode ClosingData;
	public FtpStatusCode EnteringPassive;
	public FtpStatusCode LoggedInProceed;
	public FtpStatusCode ServerWantsSecureSession;
	public FtpStatusCode FileActionOK;
	public FtpStatusCode PathnameCreated;
	public FtpStatusCode SendPasswordCommand;
	public FtpStatusCode NeedLoginAccount;
	public FtpStatusCode FileCommandPending;
	public FtpStatusCode ServiceNotAvailable;
	public FtpStatusCode CantOpenData;
	public FtpStatusCode ConnectionClosed;
	public FtpStatusCode ActionNotTakenFileUnavailableOrBusy;
	public FtpStatusCode ActionAbortedLocalProcessingError;
	public FtpStatusCode ActionNotTakenInsufficientSpace;
	public FtpStatusCode CommandSyntaxError;
	public FtpStatusCode ArgumentSyntaxError;
	public FtpStatusCode CommandNotImplemented;
	public FtpStatusCode BadCommandSequence;
	public FtpStatusCode NotLoggedIn;
	public FtpStatusCode AccountNeeded;
	public FtpStatusCode ActionNotTakenFileUnavailable;
	public FtpStatusCode ActionAbortedUnknownPageType;
	public FtpStatusCode FileActionAborted;
	public FtpStatusCode ActionNotTakenFilenameNotAllowed;
}


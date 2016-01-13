public class ManagementStatus : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ManagementStatus NoError;
	public ManagementStatus False;
	public ManagementStatus ResetToDefault;
	public ManagementStatus Different;
	public ManagementStatus Timedout;
	public ManagementStatus NoMoreData;
	public ManagementStatus OperationCanceled;
	public ManagementStatus Pending;
	public ManagementStatus DuplicateObjects;
	public ManagementStatus PartialResults;
	public ManagementStatus Failed;
	public ManagementStatus NotFound;
	public ManagementStatus AccessDenied;
	public ManagementStatus ProviderFailure;
	public ManagementStatus TypeMismatch;
	public ManagementStatus OutOfMemory;
	public ManagementStatus InvalidContext;
	public ManagementStatus InvalidParameter;
	public ManagementStatus NotAvailable;
	public ManagementStatus CriticalError;
	public ManagementStatus InvalidStream;
	public ManagementStatus NotSupported;
	public ManagementStatus InvalidSuperclass;
	public ManagementStatus InvalidNamespace;
	public ManagementStatus InvalidObject;
	public ManagementStatus InvalidClass;
	public ManagementStatus ProviderNotFound;
	public ManagementStatus InvalidProviderRegistration;
	public ManagementStatus ProviderLoadFailure;
	public ManagementStatus InitializationFailure;
	public ManagementStatus TransportFailure;
	public ManagementStatus InvalidOperation;
	public ManagementStatus InvalidQuery;
	public ManagementStatus InvalidQueryType;
	public ManagementStatus AlreadyExists;
	public ManagementStatus OverrideNotAllowed;
	public ManagementStatus PropagatedQualifier;
	public ManagementStatus PropagatedProperty;
	public ManagementStatus Unexpected;
	public ManagementStatus IllegalOperation;
	public ManagementStatus CannotBeKey;
	public ManagementStatus IncompleteClass;
	public ManagementStatus InvalidSyntax;
	public ManagementStatus NondecoratedObject;
	public ManagementStatus ReadOnly;
	public ManagementStatus ProviderNotCapable;
	public ManagementStatus ClassHasChildren;
	public ManagementStatus ClassHasInstances;
	public ManagementStatus QueryNotImplemented;
	public ManagementStatus IllegalNull;
	public ManagementStatus InvalidQualifierType;
	public ManagementStatus InvalidPropertyType;
	public ManagementStatus ValueOutOfRange;
	public ManagementStatus CannotBeSingleton;
	public ManagementStatus InvalidCimType;
	public ManagementStatus InvalidMethod;
	public ManagementStatus InvalidMethodParameters;
	public ManagementStatus SystemProperty;
	public ManagementStatus InvalidProperty;
	public ManagementStatus CallCanceled;
	public ManagementStatus ShuttingDown;
	public ManagementStatus PropagatedMethod;
	public ManagementStatus UnsupportedParameter;
	public ManagementStatus MissingParameterID;
	public ManagementStatus InvalidParameterID;
	public ManagementStatus NonconsecutiveParameterIDs;
	public ManagementStatus ParameterIDOnRetval;
	public ManagementStatus InvalidObjectPath;
	public ManagementStatus OutOfDiskSpace;
	public ManagementStatus BufferTooSmall;
	public ManagementStatus UnsupportedPutExtension;
	public ManagementStatus UnknownObjectType;
	public ManagementStatus UnknownPacketType;
	public ManagementStatus MarshalVersionMismatch;
	public ManagementStatus MarshalInvalidSignature;
	public ManagementStatus InvalidQualifier;
	public ManagementStatus InvalidDuplicateParameter;
	public ManagementStatus TooMuchData;
	public ManagementStatus ServerTooBusy;
	public ManagementStatus InvalidFlavor;
	public ManagementStatus CircularReference;
	public ManagementStatus UnsupportedClassUpdate;
	public ManagementStatus CannotChangeKeyInheritance;
	public ManagementStatus CannotChangeIndexInheritance;
	public ManagementStatus TooManyProperties;
	public ManagementStatus UpdateTypeMismatch;
	public ManagementStatus UpdateOverrideNotAllowed;
	public ManagementStatus UpdatePropagatedMethod;
	public ManagementStatus MethodNotImplemented;
	public ManagementStatus MethodDisabled;
	public ManagementStatus RefresherBusy;
	public ManagementStatus UnparsableQuery;
	public ManagementStatus NotEventClass;
	public ManagementStatus MissingGroupWithin;
	public ManagementStatus MissingAggregationList;
	public ManagementStatus PropertyNotAnObject;
	public ManagementStatus AggregatingByObject;
	public ManagementStatus UninterpretableProviderQuery;
	public ManagementStatus BackupRestoreWinmgmtRunning;
	public ManagementStatus QueueOverflow;
	public ManagementStatus PrivilegeNotHeld;
	public ManagementStatus InvalidOperator;
	public ManagementStatus LocalCredentials;
	public ManagementStatus CannotBeAbstract;
	public ManagementStatus AmendedObject;
	public ManagementStatus ClientTooSlow;
	public ManagementStatus RegistrationTooBroad;
	public ManagementStatus RegistrationTooPrecise;
}


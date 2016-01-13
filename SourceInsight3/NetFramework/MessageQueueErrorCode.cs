public class MessageQueueErrorCode : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public MessageQueueErrorCode Base;
	public MessageQueueErrorCode Generic;
	public MessageQueueErrorCode Property;
	public MessageQueueErrorCode QueueNotFound;
	public MessageQueueErrorCode QueueExists;
	public MessageQueueErrorCode InvalidParameter;
	public MessageQueueErrorCode InvalidHandle;
	public MessageQueueErrorCode OperationCanceled;
	public MessageQueueErrorCode SharingViolation;
	public MessageQueueErrorCode ServiceNotAvailable;
	public MessageQueueErrorCode MachineNotFound;
	public MessageQueueErrorCode IllegalSort;
	public MessageQueueErrorCode IllegalUser;
	public MessageQueueErrorCode NoDs;
	public MessageQueueErrorCode IllegalQueuePathName;
	public MessageQueueErrorCode IllegalPropertyValue;
	public MessageQueueErrorCode IllegalPropertyVt;
	public MessageQueueErrorCode BufferOverflow;
	public MessageQueueErrorCode IOTimeout;
	public MessageQueueErrorCode IllegalCursorAction;
	public MessageQueueErrorCode MessageAlreadyReceived;
	public MessageQueueErrorCode IllegalFormatName;
	public MessageQueueErrorCode FormatNameBufferTooSmall;
	public MessageQueueErrorCode UnsupportedFormatNameOperation;
	public MessageQueueErrorCode IllegalSecurityDescriptor;
	public MessageQueueErrorCode SenderIdBufferTooSmall;
	public MessageQueueErrorCode SecurityDescriptorBufferTooSmall;
	public MessageQueueErrorCode CannotImpersonateClient;
	public MessageQueueErrorCode AccessDenied;
	public MessageQueueErrorCode PrivilegeNotHeld;
	public MessageQueueErrorCode InsufficientResources;
	public MessageQueueErrorCode UserBufferTooSmall;
	public MessageQueueErrorCode MessageStorageFailed;
	public MessageQueueErrorCode SenderCertificateBufferTooSmall;
	public MessageQueueErrorCode InvalidCertificate;
	public MessageQueueErrorCode CorruptedInternalCertificate;
	public MessageQueueErrorCode NoInternalUserCertificate;
	public MessageQueueErrorCode CorruptedSecurityData;
	public MessageQueueErrorCode CorruptedPersonalCertStore;
	public MessageQueueErrorCode ComputerDoesNotSupportEncryption;
	public MessageQueueErrorCode BadSecurityContext;
	public MessageQueueErrorCode CouldNotGetUserSid;
	public MessageQueueErrorCode CouldNotGetAccountInfo;
	public MessageQueueErrorCode IllegalCriteriaColumns;
	public MessageQueueErrorCode IllegalPropertyId;
	public MessageQueueErrorCode IllegalRelation;
	public MessageQueueErrorCode IllegalPropertySize;
	public MessageQueueErrorCode IllegalRestrictionPropertyId;
	public MessageQueueErrorCode IllegalQueueProperties;
	public MessageQueueErrorCode PropertyNotAllowed;
	public MessageQueueErrorCode InsufficientProperties;
	public MessageQueueErrorCode MachineExists;
	public MessageQueueErrorCode IllegalMessageProperties;
	public MessageQueueErrorCode DsIsFull;
	public MessageQueueErrorCode DsError;
	public MessageQueueErrorCode InvalidOwner;
	public MessageQueueErrorCode UnsupportedAccessMode;
	public MessageQueueErrorCode ResultBufferTooSmall;
	public MessageQueueErrorCode DeleteConnectedNetworkInUse;
	public MessageQueueErrorCode NoResponseFromObjectServer;
	public MessageQueueErrorCode ObjectServerNotAvailable;
	public MessageQueueErrorCode QueueNotAvailable;
	public MessageQueueErrorCode DtcConnect;
	public MessageQueueErrorCode TransactionImport;
	public MessageQueueErrorCode TransactionUsage;
	public MessageQueueErrorCode TransactionSequence;
	public MessageQueueErrorCode MissingConnectorType;
	public MessageQueueErrorCode StaleHandle;
	public MessageQueueErrorCode TransactionEnlist;
	public MessageQueueErrorCode QueueDeleted;
	public MessageQueueErrorCode IllegalContext;
	public MessageQueueErrorCode IllegalSortPropertyId;
	public MessageQueueErrorCode LabelBufferTooSmall;
	public MessageQueueErrorCode MqisServerEmpty;
	public MessageQueueErrorCode MqisReadOnlyMode;
	public MessageQueueErrorCode SymmetricKeyBufferTooSmall;
	public MessageQueueErrorCode SignatureBufferTooSmall;
	public MessageQueueErrorCode ProviderNameBufferTooSmall;
	public MessageQueueErrorCode IllegalOperation;
	public MessageQueueErrorCode WriteNotAllowed;
	public MessageQueueErrorCode WksCantServeClient;
	public MessageQueueErrorCode DependentClientLicenseOverflow;
	public MessageQueueErrorCode CorruptedQueueWasDeleted;
	public MessageQueueErrorCode RemoteMachineNotAvailable;
	public MessageQueueErrorCode UnsupportedOperation;
	public MessageQueueErrorCode EncryptionProviderNotSupported;
	public MessageQueueErrorCode CannotSetCryptographicSecurityDescriptor;
	public MessageQueueErrorCode CertificateNotProvided;
	public MessageQueueErrorCode QDnsPropertyNotSupported;
	public MessageQueueErrorCode CannotCreateCertificateStore;
	public MessageQueueErrorCode CannotOpenCertificateStore;
	public MessageQueueErrorCode IllegalEnterpriseOperation;
	public MessageQueueErrorCode CannotGrantAddGuid;
	public MessageQueueErrorCode CannotLoadMsmqOcm;
	public MessageQueueErrorCode NoEntryPointMsmqOcm;
	public MessageQueueErrorCode NoMsmqServersOnDc;
	public MessageQueueErrorCode CannotJoinDomain;
	public MessageQueueErrorCode CannotCreateOnGlobalCatalog;
	public MessageQueueErrorCode GuidNotMatching;
	public MessageQueueErrorCode PublicKeyNotFound;
	public MessageQueueErrorCode PublicKeyDoesNotExist;
	public MessageQueueErrorCode IllegalPrivateProperties;
	public MessageQueueErrorCode NoGlobalCatalogInDomain;
	public MessageQueueErrorCode NoMsmqServersOnGlobalCatalog;
	public MessageQueueErrorCode CannotGetDistinguishedName;
	public MessageQueueErrorCode CannotHashDataEx;
	public MessageQueueErrorCode CannotSignDataEx;
	public MessageQueueErrorCode CannotCreateHashEx;
	public MessageQueueErrorCode FailVerifySignatureEx;
	public MessageQueueErrorCode MessageNotFound;
}


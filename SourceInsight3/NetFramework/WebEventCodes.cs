public class WebEventCodes
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int InvalidEventCode;
	public int UndefinedEventCode;
	public int UndefinedEventDetailCode;
	public int ApplicationCodeBase;
	public int ApplicationStart;
	public int ApplicationShutdown;
	public int ApplicationCompilationStart;
	public int ApplicationCompilationEnd;
	public int ApplicationHeartbeat;
	public int RequestCodeBase;
	public int RequestTransactionComplete;
	public int RequestTransactionAbort;
	public int ErrorCodeBase;
	public int RuntimeErrorRequestAbort;
	public int RuntimeErrorViewStateFailure;
	public int RuntimeErrorValidationFailure;
	public int RuntimeErrorPostTooLarge;
	public int RuntimeErrorUnhandledException;
	public int WebErrorParserError;
	public int WebErrorCompilationError;
	public int WebErrorConfigurationError;
	public int WebErrorOtherError;
	public int WebErrorPropertyDeserializationError;
	public int WebErrorObjectStateFormatterDeserializationError;
	public int AuditCodeBase;
	public int AuditFormsAuthenticationSuccess;
	public int AuditMembershipAuthenticationSuccess;
	public int AuditUrlAuthorizationSuccess;
	public int AuditFileAuthorizationSuccess;
	public int AuditFormsAuthenticationFailure;
	public int AuditMembershipAuthenticationFailure;
	public int AuditUrlAuthorizationFailure;
	public int AuditFileAuthorizationFailure;
	public int AuditInvalidViewStateFailure;
	public int AuditUnhandledSecurityException;
	public int AuditUnhandledAccessException;
	public int MiscCodeBase;
	public int WebEventProviderInformation;
	public int ApplicationDetailCodeBase;
	public int ApplicationShutdownUnknown;
	public int ApplicationShutdownHostingEnvironment;
	public int ApplicationShutdownChangeInGlobalAsax;
	public int ApplicationShutdownConfigurationChange;
	public int ApplicationShutdownUnloadAppDomainCalled;
	public int ApplicationShutdownChangeInSecurityPolicyFile;
	public int ApplicationShutdownBinDirChangeOrDirectoryRename;
	public int ApplicationShutdownBrowsersDirChangeOrDirectoryRename;
	public int ApplicationShutdownCodeDirChangeOrDirectoryRename;
	public int ApplicationShutdownResourcesDirChangeOrDirectoryRename;
	public int ApplicationShutdownIdleTimeout;
	public int ApplicationShutdownPhysicalApplicationPathChanged;
	public int ApplicationShutdownHttpRuntimeClose;
	public int ApplicationShutdownInitializationError;
	public int ApplicationShutdownMaxRecompilationsReached;
	public int StateServerConnectionError;
	public int ApplicationShutdownBuildManagerChange;
	public int AuditDetailCodeBase;
	public int InvalidTicketFailure;
	public int ExpiredTicketFailure;
	public int InvalidViewStateMac;
	public int InvalidViewState;
	public int WebEventDetailCodeBase;
	public int SqlProviderEventsDropped;
	public int WebExtendedBase;
}


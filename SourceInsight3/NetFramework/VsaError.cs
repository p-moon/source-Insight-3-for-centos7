public class VsaError : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public VsaError AppDomainCannotBeSet;
	public VsaError AppDomainInvalid;
	public VsaError ApplicationBaseCannotBeSet;
	public VsaError ApplicationBaseInvalid;
	public VsaError AssemblyExpected;
	public VsaError AssemblyNameInvalid;
	public VsaError BadAssembly;
	public VsaError CachedAssemblyInvalid;
	public VsaError CallbackUnexpected;
	public VsaError CodeDOMNotAvailable;
	public VsaError CompiledStateNotFound;
	public VsaError DebugInfoNotSupported;
	public VsaError ElementNameInvalid;
	public VsaError ElementNotFound;
	public VsaError EngineBusy;
	public VsaError EngineCannotClose;
	public VsaError EngineCannotReset;
	public VsaError EngineClosed;
	public VsaError EngineEmpty;
	public VsaError EngineInitialized;
	public VsaError EngineNameInUse;
	public VsaError EngineNotCompiled;
	public VsaError EngineNotInitialized;
	public VsaError EngineNotRunning;
	public VsaError EngineRunning;
	public VsaError EventSourceInvalid;
	public VsaError EventSourceNameInUse;
	public VsaError EventSourceNameInvalid;
	public VsaError EventSourceNotFound;
	public VsaError EventSourceTypeInvalid;
	public VsaError GetCompiledStateFailed;
	public VsaError GlobalInstanceInvalid;
	public VsaError GlobalInstanceTypeInvalid;
	public VsaError InternalCompilerError;
	public VsaError ItemCannotBeRemoved;
	public VsaError ItemFlagNotSupported;
	public VsaError ItemNameInUse;
	public VsaError ItemNameInvalid;
	public VsaError ItemNotFound;
	public VsaError ItemTypeNotSupported;
	public VsaError LCIDNotSupported;
	public VsaError LoadElementFailed;
	public VsaError NotificationInvalid;
	public VsaError OptionInvalid;
	public VsaError OptionNotSupported;
	public VsaError RevokeFailed;
	public VsaError RootMonikerAlreadySet;
	public VsaError RootMonikerInUse;
	public VsaError RootMonikerInvalid;
	public VsaError RootMonikerNotSet;
	public VsaError RootMonikerProtocolInvalid;
	public VsaError RootNamespaceInvalid;
	public VsaError RootNamespaceNotSet;
	public VsaError SaveCompiledStateFailed;
	public VsaError SaveElementFailed;
	public VsaError SiteAlreadySet;
	public VsaError SiteInvalid;
	public VsaError SiteNotSet;
	public VsaError SourceItemNotAvailable;
	public VsaError SourceMonikerNotAvailable;
	public VsaError URLInvalid;
	public VsaError BrowserNotExist;
	public VsaError DebuggeeNotStarted;
	public VsaError EngineNameInvalid;
	public VsaError EngineNotExist;
	public VsaError FileFormatUnsupported;
	public VsaError FileTypeUnknown;
	public VsaError ItemCannotBeRenamed;
	public VsaError MissingSource;
	public VsaError NotInitCompleted;
	public VsaError NameTooLong;
	public VsaError ProcNameInUse;
	public VsaError ProcNameInvalid;
	public VsaError VsaServerDown;
	public VsaError MissingPdb;
	public VsaError NotClientSideAndNoUrl;
	public VsaError CannotAttachToWebServer;
	public VsaError EngineNameNotSet;
	public VsaError UnknownError;
}


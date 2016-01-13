public interface IInternalConfigHost
{

	// Methods
	public abstract virtual void Init(IInternalConfigRoot configRoot, object[] hostInitParams) {}
	public abstract virtual void InitForConfiguration(System.String& locationSubPathout , System.String& configPathout , System.String& locationConfigPath, IInternalConfigRoot configRoot, object[] hostInitConfigurationParams) {}
	public abstract virtual bool IsConfigRecordRequired(string configPath) {}
	public abstract virtual bool IsInitDelayed(IInternalConfigRecord configRecord) {}
	public abstract virtual void RequireCompleteInit(IInternalConfigRecord configRecord) {}
	public abstract virtual bool IsSecondaryRoot(string configPath) {}
	public abstract virtual string GetStreamName(string configPath) {}
	public abstract virtual string GetStreamNameForConfigSource(string streamName, string configSource) {}
	public abstract virtual object GetStreamVersion(string streamName) {}
	public abstract virtual System.IO.Stream OpenStreamForRead(string streamName) {}
	public abstract virtual System.IO.Stream OpenStreamForRead(string streamName, bool assertPermissions) {}
	public abstract virtual System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, System.Object& writeContext) {}
	public abstract virtual System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, System.Object& writeContext, bool assertPermissions) {}
	public abstract virtual void WriteCompleted(string streamName, bool success, object writeContext) {}
	public abstract virtual void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions) {}
	public abstract virtual void DeleteStream(string streamName) {}
	public abstract virtual bool IsFile(string streamName) {}
	public abstract virtual object StartMonitoringStreamForChanges(string streamName, StreamChangeCallback callback) {}
	public abstract virtual void StopMonitoringStreamForChanges(string streamName, StreamChangeCallback callback) {}
	public abstract virtual bool IsAboveApplication(string configPath) {}
	public abstract virtual string GetConfigPathFromLocationSubPath(string configPath, string locationSubPath) {}
	public abstract virtual bool IsLocationApplicable(string configPath) {}
	public abstract virtual bool IsDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition) {}
	public abstract virtual void VerifyDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition, IConfigErrorInfo errorInfo) {}
	public abstract virtual bool IsTrustedConfigPath(string configPath) {}
	public abstract virtual bool IsFullTrustSectionWithoutAptcaAllowed(IInternalConfigRecord configRecord) {}
	public abstract virtual void GetRestrictedPermissions(IInternalConfigRecord configRecordout , System.Security.PermissionSet& permissionSetout , System.Boolean& isHostReady) {}
	public abstract virtual System.IDisposable Impersonate() {}
	public abstract virtual bool PrefetchAll(string configPath, string streamName) {}
	public abstract virtual bool PrefetchSection(string sectionGroupName, string sectionName) {}
	public abstract virtual object CreateDeprecatedConfigContext(string configPath) {}
	public abstract virtual object CreateConfigurationContext(string configPath, string locationSubPath) {}
	public abstract virtual string DecryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedConfigSection) {}
	public abstract virtual string EncryptSection(string clearTextXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedConfigSection) {}
	public abstract virtual Type GetConfigType(string typeName, bool throwOnError) {}
	public abstract virtual string GetConfigTypeName(Type t) {}

	// Properties
	public bool SupportsChangeNotifications { get{} }
	public bool SupportsRefresh { get{} }
	public bool SupportsPath { get{} }
	public bool SupportsLocation { get{} }
	public bool IsRemote { get{} }
}


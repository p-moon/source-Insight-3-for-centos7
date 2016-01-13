public class DelegatingConfigHost : IInternalConfigHost
{

	// Methods
	public virtual bool IsInitDelayed(IInternalConfigRecord configRecord) {}
	public virtual void RequireCompleteInit(IInternalConfigRecord configRecord) {}
	public virtual bool IsSecondaryRoot(string configPath) {}
	public virtual string GetStreamNameForConfigSource(string streamName, string configSource) {}
	public virtual object GetStreamVersion(string streamName) {}
	public virtual System.IO.Stream OpenStreamForRead(string streamName) {}
	public virtual System.IO.Stream OpenStreamForRead(string streamName, bool assertPermissions) {}
	public virtual System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, System.Object& writeContext) {}
	public virtual System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, System.Object& writeContext, bool assertPermissions) {}
	public virtual void WriteCompleted(string streamName, bool success, object writeContext) {}
	public virtual void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions) {}
	public virtual void DeleteStream(string streamName) {}
	public virtual bool IsFile(string streamName) {}
	public virtual string DecryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedConfigSection) {}
	public virtual string EncryptSection(string clearTextXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedConfigSection) {}
	public virtual void Init(IInternalConfigRoot configRoot, object[] hostInitParams) {}
	public virtual void InitForConfiguration(System.String& locationSubPathout , System.String& configPathout , System.String& locationConfigPath, IInternalConfigRoot configRoot, object[] hostInitConfigurationParams) {}
	public virtual bool IsConfigRecordRequired(string configPath) {}
	public virtual string GetStreamName(string configPath) {}
	public virtual object StartMonitoringStreamForChanges(string streamName, StreamChangeCallback callback) {}
	public virtual void StopMonitoringStreamForChanges(string streamName, StreamChangeCallback callback) {}
	public virtual bool IsAboveApplication(string configPath) {}
	public virtual bool IsDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition) {}
	public virtual void VerifyDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition, IConfigErrorInfo errorInfo) {}
	public virtual string GetConfigPathFromLocationSubPath(string configPath, string locationSubPath) {}
	public virtual bool IsLocationApplicable(string configPath) {}
	public virtual bool IsTrustedConfigPath(string configPath) {}
	public virtual bool IsFullTrustSectionWithoutAptcaAllowed(IInternalConfigRecord configRecord) {}
	public virtual void GetRestrictedPermissions(IInternalConfigRecord configRecordout , System.Security.PermissionSet& permissionSetout , System.Boolean& isHostReady) {}
	public virtual System.IDisposable Impersonate() {}
	public virtual bool PrefetchAll(string configPath, string streamName) {}
	public virtual bool PrefetchSection(string sectionGroupName, string sectionName) {}
	public virtual object CreateDeprecatedConfigContext(string configPath) {}
	public virtual object CreateConfigurationContext(string configPath, string locationSubPath) {}
	public virtual Type GetConfigType(string typeName, bool throwOnError) {}
	public virtual string GetConfigTypeName(Type t) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool SupportsChangeNotifications { get{} }
	public bool SupportsRefresh { get{} }
	public bool SupportsPath { get{} }
	public bool SupportsLocation { get{} }
	public bool IsRemote { get{} }
}


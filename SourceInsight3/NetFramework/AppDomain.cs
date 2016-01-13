public class AppDomain : MarshalByRefObject, _AppDomain, System.Security.IEvidenceFactory
{

	// Methods
	public static int GetCurrentThreadId() {}
	public bool IsFinalizingForUnload() {}
	public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) {}
	public virtual void SetData(string name, object data) {}
	public void SetData(string name, object data, System.Security.IPermission permission) {}
	public virtual object GetData(string name) {}
	public static AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, AppDomainSetup info) {}
	public void SetDynamicBase(string path) {}
	public object CreateInstanceAndUnwrap(string assemblyName, string typeName) {}
	public bool IsDefaultAppDomain() {}
	public virtual Type GetType() {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access) {}
	public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir) {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence) {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence) {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) {}
	public virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized) {}
	public System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized, IEnumerable<System.Reflection.Emit.CustomAttributeBuilder> assemblyAttributes) {}
	public string ApplyPolicy(string assemblyName) {}
	public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) {}
	public System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyName, string typeName) {}
	public System.Runtime.Remoting.ObjectHandle CreateComInstanceFrom(string assemblyFile, string typeName, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) {}
	public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) {}
	public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) {}
	public virtual System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) {}
	public virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) {}
	public virtual System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) {}
	public virtual System.Reflection.Assembly Load(string assemblyString) {}
	public virtual System.Reflection.Assembly Load(byte[] rawAssembly) {}
	public virtual System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) {}
	public virtual System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) {}
	public virtual System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) {}
	public virtual System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) {}
	public virtual int ExecuteAssembly(string assemblyFile) {}
	public virtual int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity) {}
	public virtual int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args) {}
	public int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) {}
	public int ExecuteAssemblyByName(string assemblyName) {}
	public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity) {}
	public int ExecuteAssemblyByName(string assemblyName, System.Security.Policy.Evidence assemblySecurity, string[] args) {}
	public int ExecuteAssemblyByName(System.Reflection.AssemblyName assemblyName, System.Security.Policy.Evidence assemblySecurity, string[] args) {}
	public virtual string ToString() {}
	public virtual System.Reflection.Assembly[] GetAssemblies() {}
	public System.Reflection.Assembly[] ReflectionOnlyGetAssemblies() {}
	public virtual void AppendPrivatePath(string path) {}
	public virtual void ClearPrivatePath() {}
	public virtual void ClearShadowCopyPath() {}
	public virtual void SetCachePath(string path) {}
	public static void Unload(AppDomain domain) {}
	public virtual void SetAppDomainPolicy(System.Security.Policy.PolicyLevel domainPolicy) {}
	public virtual void SetThreadPrincipal(System.Security.Principal.IPrincipal principal) {}
	public virtual void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy) {}
	public virtual object InitializeLifetimeService() {}
	public virtual void DoCallBack(CrossAppDomainDelegate callBackDelegate) {}
	public static AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo) {}
	public static AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles) {}
	public static AppDomain CreateDomain(string friendlyName) {}
	public static AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, AppDomainSetup info, System.Security.PermissionSet grantSet, System.Security.Policy.StrongName[] fullTrustAssemblies) {}
	public static AppDomain CreateDomain(string friendlyName, System.Security.Policy.Evidence securityInfo, string appBasePath, string appRelativeSearchPath, bool shadowCopyFiles, AppDomainInitializer adInit, string[] adInitArgs) {}
	public virtual void SetShadowCopyPath(string path) {}
	public void SetShadowCopyFiles() {}
	public object CreateInstanceAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) {}
	public object CreateInstanceAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) {}
	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName) {}
	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, object[] activationAttributes) {}
	public object CreateInstanceFromAndUnwrap(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AppDomainManager DomainManager { get{} }
	public AppDomain CurrentDomain { get{} }
	public System.Security.Policy.Evidence Evidence { get{} }
	public string FriendlyName { get{} }
	public string BaseDirectory { get{} }
	public string RelativeSearchPath { get{} }
	public bool ShadowCopyFiles { get{} }
	public ActivationContext ActivationContext { get{} }
	public ApplicationIdentity ApplicationIdentity { get{} }
	public System.Security.Policy.ApplicationTrust ApplicationTrust { get{} }
	public string DynamicDirectory { get{} }
	public AppDomainSetup SetupInformation { get{} }
	public int Id { get{} }

	// Events
	public event System.AssemblyLoadEventHandler AssemblyLoad;
	public event System.ResolveEventHandler TypeResolve;
	public event System.ResolveEventHandler ResourceResolve;
	public event System.ResolveEventHandler AssemblyResolve;
	public event System.ResolveEventHandler ReflectionOnlyAssemblyResolve;
	public event System.EventHandler ProcessExit;
	public event System.EventHandler DomainUnload;
	public event System.UnhandledExceptionEventHandler UnhandledException;
}


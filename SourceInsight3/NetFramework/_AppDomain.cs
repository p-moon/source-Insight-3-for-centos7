public interface _AppDomain
{

	// Methods
	public abstract virtual void SetThreadPrincipal(System.Security.Principal.IPrincipal principal) {}
	public abstract virtual void SetPrincipalPolicy(System.Security.Principal.PrincipalPolicy policy) {}
	public abstract virtual void DoCallBack(CrossAppDomainDelegate theDelegate) {}
	public abstract virtual void GetTypeInfoCount(out UInt32& pcTInfo) {}
	public abstract virtual void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo) {}
	public abstract virtual void GetIDsOfNames(Guid& riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId) {}
	public abstract virtual void Invoke(uint dispIdMember, Guid& riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr) {}
	public abstract virtual string ToString() {}
	public abstract virtual bool Equals(object other) {}
	public abstract virtual int GetHashCode() {}
	public abstract virtual Type GetType() {}
	public abstract virtual object InitializeLifetimeService() {}
	public abstract virtual object GetLifetimeService() {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions) {}
	public abstract virtual System.Reflection.Emit.AssemblyBuilder DefineDynamicAssembly(System.Reflection.AssemblyName name, System.Reflection.Emit.AssemblyBuilderAccess access, string dir, System.Security.Policy.Evidence evidence, System.Security.PermissionSet requiredPermissions, System.Security.PermissionSet optionalPermissions, System.Security.PermissionSet refusedPermissions, bool isSynchronized) {}
	public abstract virtual System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName) {}
	public abstract virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName) {}
	public abstract virtual System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, object[] activationAttributes) {}
	public abstract virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, object[] activationAttributes) {}
	public abstract virtual System.Runtime.Remoting.ObjectHandle CreateInstance(string assemblyName, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) {}
	public abstract virtual System.Runtime.Remoting.ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes, System.Security.Policy.Evidence securityAttributes) {}
	public abstract virtual System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef) {}
	public abstract virtual System.Reflection.Assembly Load(string assemblyString) {}
	public abstract virtual System.Reflection.Assembly Load(byte[] rawAssembly) {}
	public abstract virtual System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) {}
	public abstract virtual System.Reflection.Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) {}
	public abstract virtual System.Reflection.Assembly Load(System.Reflection.AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) {}
	public abstract virtual System.Reflection.Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) {}
	public abstract virtual int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity) {}
	public abstract virtual int ExecuteAssembly(string assemblyFile) {}
	public abstract virtual int ExecuteAssembly(string assemblyFile, System.Security.Policy.Evidence assemblySecurity, string[] args) {}
	public abstract virtual System.Reflection.Assembly[] GetAssemblies() {}
	public abstract virtual void AppendPrivatePath(string path) {}
	public abstract virtual void ClearPrivatePath() {}
	public abstract virtual void SetShadowCopyPath(string s) {}
	public abstract virtual void ClearShadowCopyPath() {}
	public abstract virtual void SetCachePath(string s) {}
	public abstract virtual void SetData(string name, object data) {}
	public abstract virtual object GetData(string name) {}
	public abstract virtual void SetAppDomainPolicy(System.Security.Policy.PolicyLevel domainPolicy) {}

	// Properties
	public System.Security.Policy.Evidence Evidence { get{} }
	public string FriendlyName { get{} }
	public string BaseDirectory { get{} }
	public string RelativeSearchPath { get{} }
	public bool ShadowCopyFiles { get{} }
	public string DynamicDirectory { get{} }

	// Events
	public event System.EventHandler DomainUnload;
	public event System.AssemblyLoadEventHandler AssemblyLoad;
	public event System.EventHandler ProcessExit;
	public event System.ResolveEventHandler TypeResolve;
	public event System.ResolveEventHandler ResourceResolve;
	public event System.ResolveEventHandler AssemblyResolve;
	public event System.UnhandledExceptionEventHandler UnhandledException;
}


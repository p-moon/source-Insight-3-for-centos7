public class Assembly : System.Runtime.InteropServices._Assembly, System.Security.IEvidenceFactory, ICustomAttributeProvider, System.Runtime.Serialization.ISerializable
{

	// Methods
	public static string CreateQualifiedName(string assemblyName, string typeName) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual AssemblyName GetName() {}
	public virtual AssemblyName GetName(bool copiedName) {}
	public static Assembly GetAssembly(Type type) {}
	public virtual Type GetType(string name) {}
	public virtual Type GetType(string name, bool throwOnError) {}
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) {}
	public virtual Type[] GetExportedTypes() {}
	public virtual Type[] GetTypes() {}
	public virtual System.IO.Stream GetManifestResourceStream(Type type, string name) {}
	public virtual System.IO.Stream GetManifestResourceStream(string name) {}
	public virtual Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture) {}
	public virtual Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture, System.Version version) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public static Assembly LoadFrom(string assemblyFile) {}
	public static Assembly ReflectionOnlyLoadFrom(string assemblyFile) {}
	public static Assembly LoadFrom(string assemblyFile, System.Security.Policy.Evidence securityEvidence) {}
	public static Assembly LoadFrom(string assemblyFile, System.Security.Policy.Evidence securityEvidence, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) {}
	public static Assembly Load(string assemblyString) {}
	public static Assembly ReflectionOnlyLoad(string assemblyString) {}
	public static Assembly Load(string assemblyString, System.Security.Policy.Evidence assemblySecurity) {}
	public static Assembly Load(AssemblyName assemblyRef) {}
	public static Assembly Load(AssemblyName assemblyRef, System.Security.Policy.Evidence assemblySecurity) {}
	public static Assembly LoadWithPartialName(string partialName) {}
	public static Assembly LoadWithPartialName(string partialName, System.Security.Policy.Evidence securityEvidence) {}
	public static Assembly Load(byte[] rawAssembly) {}
	public static Assembly ReflectionOnlyLoad(byte[] rawAssembly) {}
	public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore) {}
	public static Assembly Load(byte[] rawAssembly, byte[] rawSymbolStore, System.Security.Policy.Evidence securityEvidence) {}
	public static Assembly LoadFile(string path) {}
	public static Assembly LoadFile(string path, System.Security.Policy.Evidence securityEvidence) {}
	public virtual Module LoadModule(string moduleName, byte[] rawModule) {}
	public virtual Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore) {}
	public virtual object CreateInstance(string typeName) {}
	public virtual object CreateInstance(string typeName, bool ignoreCase) {}
	public virtual object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) {}
	public virtual Module[] GetLoadedModules() {}
	public virtual Module[] GetLoadedModules(bool getResourceModules) {}
	public virtual Module[] GetModules() {}
	public virtual Module[] GetModules(bool getResourceModules) {}
	public virtual Module GetModule(string name) {}
	public virtual System.IO.FileStream GetFile(string name) {}
	public virtual System.IO.FileStream[] GetFiles() {}
	public virtual System.IO.FileStream[] GetFiles(bool getResourceModules) {}
	public virtual string[] GetManifestResourceNames() {}
	public static Assembly GetExecutingAssembly() {}
	public static Assembly GetCallingAssembly() {}
	public static Assembly GetEntryAssembly() {}
	public virtual AssemblyName[] GetReferencedAssemblies() {}
	public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string CodeBase { get{} }
	public string EscapedCodeBase { get{} }
	public string FullName { get{} }
	public MethodInfo EntryPoint { get{} }
	public System.Security.Policy.Evidence Evidence { get{} }
	public Module ManifestModule { get{} }
	public bool ReflectionOnly { get{} }
	public string Location { get{} }
	public string ImageRuntimeVersion { get{} }
	public bool GlobalAssemblyCache { get{} }
	public long HostContext { get{} }

	// Events
	public event System.Reflection.ModuleResolveEventHandler ModuleResolve;
}


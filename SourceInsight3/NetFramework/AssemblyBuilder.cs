public class AssemblyBuilder : System.Reflection.Assembly, System.Runtime.InteropServices._Assembly, System.Security.IEvidenceFactory, System.Reflection.ICustomAttributeProvider, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._AssemblyBuilder
{

	// Methods
	public ModuleBuilder DefineDynamicModule(string name) {}
	public ModuleBuilder DefineDynamicModule(string name, bool emitSymbolInfo) {}
	public ModuleBuilder DefineDynamicModule(string name, string fileName) {}
	public ModuleBuilder DefineDynamicModule(string name, string fileName, bool emitSymbolInfo) {}
	public System.Resources.IResourceWriter DefineResource(string name, string description, string fileName) {}
	public System.Resources.IResourceWriter DefineResource(string name, string description, string fileName, System.Reflection.ResourceAttributes attribute) {}
	public void AddResourceFile(string name, string fileName) {}
	public void AddResourceFile(string name, string fileName, System.Reflection.ResourceAttributes attribute) {}
	public virtual string[] GetManifestResourceNames() {}
	public virtual System.IO.FileStream GetFile(string name) {}
	public virtual System.IO.FileStream[] GetFiles(bool getResourceModules) {}
	public virtual System.IO.Stream GetManifestResourceStream(Type type, string name) {}
	public virtual System.IO.Stream GetManifestResourceStream(string name) {}
	public virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName) {}
	public virtual Type[] GetExportedTypes() {}
	public void DefineVersionInfoResource(string product, string productVersion, string company, string copyright, string trademark) {}
	public void DefineVersionInfoResource() {}
	public void DefineUnmanagedResource(byte[] resource) {}
	public void DefineUnmanagedResource(string resourceFileName) {}
	public ModuleBuilder GetDynamicModule(string name) {}
	public void SetEntryPoint(System.Reflection.MethodInfo entryMethod) {}
	public void SetEntryPoint(System.Reflection.MethodInfo entryMethod, PEFileKinds fileKind) {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public void Save(string assemblyFileName) {}
	public void Save(string assemblyFileName, System.Reflection.PortableExecutableKinds portableExecutableKind, System.Reflection.ImageFileMachine imageFileMachine) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public virtual System.Reflection.AssemblyName GetName() {}
	public virtual System.Reflection.AssemblyName GetName(bool copiedName) {}
	public virtual Type GetType(string name) {}
	public virtual Type GetType(string name, bool throwOnError) {}
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) {}
	public virtual Type[] GetTypes() {}
	public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture) {}
	public virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture, System.Version version) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public virtual System.Reflection.Module LoadModule(string moduleName, byte[] rawModule) {}
	public virtual System.Reflection.Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore) {}
	public virtual object CreateInstance(string typeName) {}
	public virtual object CreateInstance(string typeName, bool ignoreCase) {}
	public virtual object CreateInstance(string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) {}
	public virtual System.Reflection.Module[] GetLoadedModules() {}
	public virtual System.Reflection.Module[] GetLoadedModules(bool getResourceModules) {}
	public virtual System.Reflection.Module[] GetModules() {}
	public virtual System.Reflection.Module[] GetModules(bool getResourceModules) {}
	public virtual System.Reflection.Module GetModule(string name) {}
	public virtual System.IO.FileStream[] GetFiles() {}
	public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public string Location { get{} }
	public string ImageRuntimeVersion { get{} }
	public string CodeBase { get{} }
	public System.Reflection.MethodInfo EntryPoint { get{} }
	public string EscapedCodeBase { get{} }
	public string FullName { get{} }
	public System.Security.Policy.Evidence Evidence { get{} }
	public System.Reflection.Module ManifestModule { get{} }
	public bool ReflectionOnly { get{} }
	public bool GlobalAssemblyCache { get{} }
	public long HostContext { get{} }

	// Events
	public event System.Reflection.ModuleResolveEventHandler ModuleResolve;
}


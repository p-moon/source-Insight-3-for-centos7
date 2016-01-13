public interface _Assembly
{

	// Methods
	public abstract virtual string ToString() {}
	public abstract virtual bool Equals(object other) {}
	public abstract virtual int GetHashCode() {}
	public abstract virtual Type GetType() {}
	public abstract virtual System.Reflection.AssemblyName GetName() {}
	public abstract virtual System.Reflection.AssemblyName GetName(bool copiedName) {}
	public abstract virtual Type GetType(string name) {}
	public abstract virtual Type GetType(string name, bool throwOnError) {}
	public abstract virtual Type[] GetExportedTypes() {}
	public abstract virtual Type[] GetTypes() {}
	public abstract virtual System.IO.Stream GetManifestResourceStream(Type type, string name) {}
	public abstract virtual System.IO.Stream GetManifestResourceStream(string name) {}
	public abstract virtual System.IO.FileStream GetFile(string name) {}
	public abstract virtual System.IO.FileStream[] GetFiles() {}
	public abstract virtual System.IO.FileStream[] GetFiles(bool getResourceModules) {}
	public abstract virtual string[] GetManifestResourceNames() {}
	public abstract virtual System.Reflection.ManifestResourceInfo GetManifestResourceInfo(string resourceName) {}
	public abstract virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public abstract virtual object[] GetCustomAttributes(bool inherit) {}
	public abstract virtual bool IsDefined(Type attributeType, bool inherit) {}
	public abstract virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public abstract virtual Type GetType(string name, bool throwOnError, bool ignoreCase) {}
	public abstract virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture) {}
	public abstract virtual System.Reflection.Assembly GetSatelliteAssembly(System.Globalization.CultureInfo culture, System.Version version) {}
	public abstract virtual System.Reflection.Module LoadModule(string moduleName, byte[] rawModule) {}
	public abstract virtual System.Reflection.Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore) {}
	public abstract virtual object CreateInstance(string typeName) {}
	public abstract virtual object CreateInstance(string typeName, bool ignoreCase) {}
	public abstract virtual object CreateInstance(string typeName, bool ignoreCase, System.Reflection.BindingFlags bindingAttr, System.Reflection.Binder binder, object[] args, System.Globalization.CultureInfo culture, object[] activationAttributes) {}
	public abstract virtual System.Reflection.Module[] GetLoadedModules() {}
	public abstract virtual System.Reflection.Module[] GetLoadedModules(bool getResourceModules) {}
	public abstract virtual System.Reflection.Module[] GetModules() {}
	public abstract virtual System.Reflection.Module[] GetModules(bool getResourceModules) {}
	public abstract virtual System.Reflection.Module GetModule(string name) {}
	public abstract virtual System.Reflection.AssemblyName[] GetReferencedAssemblies() {}

	// Properties
	public string CodeBase { get{} }
	public string EscapedCodeBase { get{} }
	public string FullName { get{} }
	public System.Reflection.MethodInfo EntryPoint { get{} }
	public string Location { get{} }
	public System.Security.Policy.Evidence Evidence { get{} }
	public bool GlobalAssemblyCache { get{} }

	// Events
	public event System.Reflection.ModuleResolveEventHandler ModuleResolve;
}


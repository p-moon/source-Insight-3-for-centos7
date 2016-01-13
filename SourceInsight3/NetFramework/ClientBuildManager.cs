public class ClientBuildManager : System.MarshalByRefObject, System.IDisposable
{

	// Constructors
	public ClientBuildManager(string appVirtualDir, string appPhysicalSourceDir) {}
	public ClientBuildManager(string appVirtualDir, string appPhysicalSourceDir, string appPhysicalTargetDir) {}
	public ClientBuildManager(string appVirtualDir, string appPhysicalSourceDir, string appPhysicalTargetDir, ClientBuildManagerParameter parameter) {}

	// Methods
	public System.Web.Hosting.IRegisteredObject CreateObject(Type type, bool failIfExists) {}
	public string[] GetAppDomainShutdownDirectories() {}
	public void CompileApplicationDependencies() {}
	public System.Collections.IDictionary GetBrowserDefinitions() {}
	public string GetGeneratedSourceFile(string virtualPath) {}
	public string GetGeneratedFileVirtualPath(string filePath) {}
	public string[] GetVirtualCodeDirectories() {}
	public string[] GetTopLevelAssemblyReferences(string virtualPath) {}
	public void GetCodeDirectoryInformation(string virtualCodeDirout , System.Type& codeDomProviderTypeout , System.CodeDom.Compiler.CompilerParameters& compilerParametersout , System.String& generatedFilesDir) {}
	public void GetCompilerParameters(string virtualPathout , System.Type& codeDomProviderTypeout , System.CodeDom.Compiler.CompilerParameters& compilerParameters) {}
	public System.CodeDom.CodeCompileUnit GenerateCodeCompileUnit(string virtualPathout , System.Type& codeDomProviderTypeout , System.CodeDom.Compiler.CompilerParameters& compilerParametersout , System.Collections.IDictionary& linePragmasTable) {}
	public System.CodeDom.CodeCompileUnit GenerateCodeCompileUnit(string virtualPath, string virtualFileStringout , System.Type& codeDomProviderTypeout , System.CodeDom.Compiler.CompilerParameters& compilerParametersout , System.Collections.IDictionary& linePragmasTable) {}
	public string GenerateCode(string virtualPath, string virtualFileStringout , System.Collections.IDictionary& linePragmasTable) {}
	public Type GetCompiledType(string virtualPath) {}
	public void CompileFile(string virtualPath) {}
	public void CompileFile(string virtualPath, ClientBuildManagerCallback callback) {}
	public bool IsCodeAssembly(string assemblyName) {}
	public bool Unload() {}
	public void PrecompileApplication() {}
	public void PrecompileApplication(ClientBuildManagerCallback callback) {}
	public void PrecompileApplication(ClientBuildManagerCallback callback, bool forceCleanBuild) {}
	public virtual object InitializeLifetimeService() {}
	public virtual object GetLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CodeGenDir { get{} }
	public bool IsHostCreated { get{} }

	// Events
	public event System.Web.Compilation.BuildManagerHostUnloadEventHandler AppDomainUnloaded;
	public event System.EventHandler AppDomainStarted;
	public event System.Web.Compilation.BuildManagerHostUnloadEventHandler AppDomainShutdown;
}


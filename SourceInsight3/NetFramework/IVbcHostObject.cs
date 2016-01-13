public interface IVbcHostObject : Microsoft.Build.Framework.ITaskHost
{

	// Methods
	public abstract virtual void BeginInitialization() {}
	public abstract virtual void EndInitialization() {}
	public abstract virtual bool IsDesignTime() {}
	public abstract virtual bool Compile() {}
	public abstract virtual bool SetAdditionalLibPaths(string[] additionalLibPaths) {}
	public abstract virtual bool SetAddModules(string[] addModules) {}
	public abstract virtual bool SetBaseAddress(string targetType, string baseAddress) {}
	public abstract virtual bool SetCodePage(int codePage) {}
	public abstract virtual bool SetDebugType(bool emitDebugInformation, string debugType) {}
	public abstract virtual bool SetDefineConstants(string defineConstants) {}
	public abstract virtual bool SetDelaySign(bool delaySign) {}
	public abstract virtual bool SetDisabledWarnings(string disabledWarnings) {}
	public abstract virtual bool SetDocumentationFile(string documentationFile) {}
	public abstract virtual bool SetErrorReport(string errorReport) {}
	public abstract virtual bool SetFileAlignment(int fileAlignment) {}
	public abstract virtual bool SetGenerateDocumentation(bool generateDocumentation) {}
	public abstract virtual bool SetImports(Microsoft.Build.Framework.ITaskItem[] importsList) {}
	public abstract virtual bool SetKeyContainer(string keyContainer) {}
	public abstract virtual bool SetKeyFile(string keyFile) {}
	public abstract virtual bool SetLinkResources(Microsoft.Build.Framework.ITaskItem[] linkResources) {}
	public abstract virtual bool SetMainEntryPoint(string mainEntryPoint) {}
	public abstract virtual bool SetNoConfig(bool noConfig) {}
	public abstract virtual bool SetNoStandardLib(bool noStandardLib) {}
	public abstract virtual bool SetNoWarnings(bool noWarnings) {}
	public abstract virtual bool SetOptimize(bool optimize) {}
	public abstract virtual bool SetOptionCompare(string optionCompare) {}
	public abstract virtual bool SetOptionExplicit(bool optionExplicit) {}
	public abstract virtual bool SetOptionStrict(bool optionStrict) {}
	public abstract virtual bool SetOptionStrictType(string optionStrictType) {}
	public abstract virtual bool SetOutputAssembly(string outputAssembly) {}
	public abstract virtual bool SetPlatform(string platform) {}
	public abstract virtual bool SetReferences(Microsoft.Build.Framework.ITaskItem[] references) {}
	public abstract virtual bool SetRemoveIntegerChecks(bool removeIntegerChecks) {}
	public abstract virtual bool SetResources(Microsoft.Build.Framework.ITaskItem[] resources) {}
	public abstract virtual bool SetResponseFiles(Microsoft.Build.Framework.ITaskItem[] responseFiles) {}
	public abstract virtual bool SetRootNamespace(string rootNamespace) {}
	public abstract virtual bool SetSdkPath(string sdkPath) {}
	public abstract virtual bool SetSources(Microsoft.Build.Framework.ITaskItem[] sources) {}
	public abstract virtual bool SetTargetCompactFramework(bool targetCompactFramework) {}
	public abstract virtual bool SetTargetType(string targetType) {}
	public abstract virtual bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors) {}
	public abstract virtual bool SetWarningsAsErrors(string warningsAsErrors) {}
	public abstract virtual bool SetWarningsNotAsErrors(string warningsNotAsErrors) {}
	public abstract virtual bool SetWin32Icon(string win32Icon) {}
	public abstract virtual bool SetWin32Resource(string win32Resource) {}
	public abstract virtual bool IsUpToDate() {}
}


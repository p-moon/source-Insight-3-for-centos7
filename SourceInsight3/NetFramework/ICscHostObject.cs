public interface ICscHostObject : Microsoft.Build.Framework.ITaskHost
{

	// Methods
	public abstract virtual bool IsDesignTime() {}
	public abstract virtual bool Compile() {}
	public abstract virtual void BeginInitialization() {}
	public abstract virtual bool EndInitialization(out System.String& errorMessageout , System.Int32& errorCode) {}
	public abstract virtual bool SetAdditionalLibPaths(string[] additionalLibPaths) {}
	public abstract virtual bool SetAddModules(string[] addModules) {}
	public abstract virtual bool SetAllowUnsafeBlocks(bool allowUnsafeBlocks) {}
	public abstract virtual bool SetBaseAddress(string baseAddress) {}
	public abstract virtual bool SetCheckForOverflowUnderflow(bool checkForOverflowUnderflow) {}
	public abstract virtual bool SetCodePage(int codePage) {}
	public abstract virtual bool SetDebugType(string debugType) {}
	public abstract virtual bool SetDefineConstants(string defineConstants) {}
	public abstract virtual bool SetDelaySign(bool delaySignExplicitlySet, bool delaySign) {}
	public abstract virtual bool SetDisabledWarnings(string disabledWarnings) {}
	public abstract virtual bool SetDocumentationFile(string documentationFile) {}
	public abstract virtual bool SetEmitDebugInformation(bool emitDebugInformation) {}
	public abstract virtual bool SetErrorReport(string errorReport) {}
	public abstract virtual bool SetFileAlignment(int fileAlignment) {}
	public abstract virtual bool SetGenerateFullPaths(bool generateFullPaths) {}
	public abstract virtual bool SetKeyContainer(string keyContainer) {}
	public abstract virtual bool SetKeyFile(string keyFile) {}
	public abstract virtual bool SetLangVersion(string langVersion) {}
	public abstract virtual bool SetLinkResources(Microsoft.Build.Framework.ITaskItem[] linkResources) {}
	public abstract virtual bool SetMainEntryPoint(string targetType, string mainEntryPoint) {}
	public abstract virtual bool SetModuleAssemblyName(string moduleAssemblyName) {}
	public abstract virtual bool SetNoConfig(bool noConfig) {}
	public abstract virtual bool SetNoStandardLib(bool noStandardLib) {}
	public abstract virtual bool SetOptimize(bool optimize) {}
	public abstract virtual bool SetOutputAssembly(string outputAssembly) {}
	public abstract virtual bool SetPlatform(string platform) {}
	public abstract virtual bool SetPdbFile(string pdbFile) {}
	public abstract virtual bool SetReferences(Microsoft.Build.Framework.ITaskItem[] references) {}
	public abstract virtual bool SetResources(Microsoft.Build.Framework.ITaskItem[] resources) {}
	public abstract virtual bool SetResponseFiles(Microsoft.Build.Framework.ITaskItem[] responseFiles) {}
	public abstract virtual bool SetSources(Microsoft.Build.Framework.ITaskItem[] sources) {}
	public abstract virtual bool SetTargetType(string targetType) {}
	public abstract virtual bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors) {}
	public abstract virtual bool SetWarningLevel(int warningLevel) {}
	public abstract virtual bool SetWarningsAsErrors(string warningsAsErrors) {}
	public abstract virtual bool SetWarningsNotAsErrors(string warningsNotAsErrors) {}
	public abstract virtual bool SetWin32Icon(string win32Icon) {}
	public abstract virtual bool SetWin32Resource(string win32Resource) {}
	public abstract virtual bool IsUpToDate() {}
}


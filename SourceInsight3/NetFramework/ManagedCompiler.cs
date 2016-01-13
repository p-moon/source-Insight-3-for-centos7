public class ManagedCompiler : ToolTaskExtension, Microsoft.Build.Framework.ITask
{

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] AdditionalLibPaths { get{} set{} }
	public string[] AddModules { get{} set{} }
	public int CodePage { get{} set{} }
	public string DebugType { get{} set{} }
	public string DefineConstants { get{} set{} }
	public bool DelaySign { get{} set{} }
	public bool EmitDebugInformation { get{} set{} }
	public int FileAlignment { get{} set{} }
	public string KeyContainer { get{} set{} }
	public string KeyFile { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] LinkResources { get{} set{} }
	public string MainEntryPoint { get{} set{} }
	public bool NoConfig { get{} set{} }
	public bool NoLogo { get{} set{} }
	public bool Optimize { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem OutputAssembly { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] References { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Resources { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ResponseFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Sources { get{} set{} }
	public string TargetType { get{} set{} }
	public bool TreatWarningsAsErrors { get{} set{} }
	public bool Utf8Output { get{} set{} }
	public string Win32Icon { get{} set{} }
	public string Win32Resource { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public int ExitCode { get{} }
	public string ToolPath { get{} set{} }
	public int Timeout { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


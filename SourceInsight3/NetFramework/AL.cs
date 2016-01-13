public class AL : ToolTaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public AL() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AlgorithmId { get{} set{} }
	public string BaseAddress { get{} set{} }
	public string CompanyName { get{} set{} }
	public string Configuration { get{} set{} }
	public string Copyright { get{} set{} }
	public string Culture { get{} set{} }
	public bool DelaySign { get{} set{} }
	public string Description { get{} set{} }
	public string EvidenceFile { get{} set{} }
	public string FileVersion { get{} set{} }
	public string Flags { get{} set{} }
	public bool GenerateFullPaths { get{} set{} }
	public string KeyFile { get{} set{} }
	public string KeyContainer { get{} set{} }
	public string MainEntryPoint { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem OutputAssembly { get{} set{} }
	public string Platform { get{} set{} }
	public string ProductName { get{} set{} }
	public string ProductVersion { get{} set{} }
	public string[] ResponseFiles { get{} set{} }
	public string TargetType { get{} set{} }
	public string TemplateFile { get{} set{} }
	public string Title { get{} set{} }
	public string Trademark { get{} set{} }
	public string Version { get{} set{} }
	public string Win32Icon { get{} set{} }
	public string Win32Resource { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] SourceModules { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] EmbedResources { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] LinkResources { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public int ExitCode { get{} }
	public string ToolPath { get{} set{} }
	public int Timeout { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


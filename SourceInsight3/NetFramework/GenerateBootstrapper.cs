public class GenerateBootstrapper : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public GenerateBootstrapper() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationName { get{} set{} }
	public string ApplicationFile { get{} set{} }
	public string ApplicationUrl { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] BootstrapperItems { get{} set{} }
	public string ComponentsLocation { get{} set{} }
	public string ComponentsUrl { get{} set{} }
	public bool CopyComponents { get{} set{} }
	public string Culture { get{} set{} }
	public string FallbackCulture { get{} set{} }
	public string OutputPath { get{} set{} }
	public string Path { get{} set{} }
	public string SupportUrl { get{} set{} }
	public bool Validate { get{} set{} }
	public string BootstrapperKeyFile { get{} set{} }
	public string[] BootstrapperComponentFiles { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


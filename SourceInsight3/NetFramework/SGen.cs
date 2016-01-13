public class SGen : ToolTaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public SGen() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string BuildAssemblyName { get{} set{} }
	public string BuildAssemblyPath { get{} set{} }
	public bool ShouldGenerateSerializer { get{} set{} }
	public bool UseProxyTypes { get{} set{} }
	public string[] References { get{} set{} }
	public string KeyContainer { get{} set{} }
	public string KeyFile { get{} set{} }
	public bool DelaySign { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] SerializationAssembly { get{} set{} }
	public string SerializationAssemblyName { get{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public int ExitCode { get{} }
	public string ToolPath { get{} set{} }
	public int Timeout { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


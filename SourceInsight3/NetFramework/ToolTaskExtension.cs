public class ToolTaskExtension : Microsoft.Build.Utilities.ToolTask, Microsoft.Build.Framework.ITask
{

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public int ExitCode { get{} }
	public string ToolPath { get{} set{} }
	public int Timeout { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


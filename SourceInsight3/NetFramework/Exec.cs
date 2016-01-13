public class Exec : ToolTaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public Exec() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Command { get{} set{} }
	public string WorkingDirectory { get{} set{} }
	public bool IgnoreExitCode { get{} set{} }
	public string StdOutEncoding { get{} set{} }
	public string StdErrEncoding { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Outputs { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public int ExitCode { get{} }
	public string ToolPath { get{} set{} }
	public int Timeout { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


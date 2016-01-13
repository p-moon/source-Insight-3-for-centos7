public class AssignTargetPath : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public AssignTargetPath() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string RootFolder { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Files { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] AssignedFiles { get{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


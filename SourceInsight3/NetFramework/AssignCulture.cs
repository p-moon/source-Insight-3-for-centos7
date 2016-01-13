public class AssignCulture : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public AssignCulture() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] Files { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] AssignedFiles { get{} }
	public Microsoft.Build.Framework.ITaskItem[] AssignedFilesWithCulture { get{} }
	public Microsoft.Build.Framework.ITaskItem[] AssignedFilesWithNoCulture { get{} }
	public Microsoft.Build.Framework.ITaskItem[] CultureNeutralAssignedFiles { get{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


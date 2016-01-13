public class CombinePath : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public CombinePath() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string BasePath { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Paths { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] CombinedPaths { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


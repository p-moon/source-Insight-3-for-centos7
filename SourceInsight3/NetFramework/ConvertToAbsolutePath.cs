public class ConvertToAbsolutePath : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public ConvertToAbsolutePath() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] Paths { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] AbsolutePaths { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


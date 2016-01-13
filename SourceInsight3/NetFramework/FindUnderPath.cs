public class FindUnderPath : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public FindUnderPath() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem Path { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Files { get{} set{} }
	public bool UpdateToAbsolutePaths { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] InPath { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] OutOfPath { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


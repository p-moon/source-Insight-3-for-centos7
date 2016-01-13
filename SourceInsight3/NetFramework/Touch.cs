public class Touch : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public Touch() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool ForceTouch { get{} set{} }
	public bool AlwaysCreate { get{} set{} }
	public string Time { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Files { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] TouchedFiles { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


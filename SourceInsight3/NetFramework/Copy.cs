public class Copy : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public Copy() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] SourceFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem DestinationFolder { get{} set{} }
	public bool SkipUnchangedFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] DestinationFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] CopiedFiles { get{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


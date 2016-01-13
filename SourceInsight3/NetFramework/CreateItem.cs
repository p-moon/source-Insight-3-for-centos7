public class CreateItem : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public CreateItem() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] Include { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Exclude { get{} set{} }
	public string[] AdditionalMetadata { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


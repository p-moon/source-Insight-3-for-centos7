public class Delete : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public Delete() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] Files { get{} set{} }
	public bool TreatErrorsAsWarnings { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] DeletedFiles { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


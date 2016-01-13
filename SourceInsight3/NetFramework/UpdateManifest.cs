public class UpdateManifest : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ITask
{

	// Constructors
	public UpdateManifest() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationPath { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem ApplicationManifest { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem InputManifest { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem OutputManifest { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
}


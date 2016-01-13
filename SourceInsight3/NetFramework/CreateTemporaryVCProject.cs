public class CreateTemporaryVCProject : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public CreateTemporaryVCProject() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem ProjectFile { get{} set{} }
	public string Configuration { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem OutputProjectFile { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ReferenceGuids { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ReferenceAssemblies { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ReferenceImportLibraries { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


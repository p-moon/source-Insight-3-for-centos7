public class GenerateResource : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public GenerateResource() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] Sources { get{} set{} }
	public bool UseSourcePath { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] References { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem StateFile { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] OutputResources { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get{} }
	public string StronglyTypedLanguage { get{} set{} }
	public string StronglyTypedNamespace { get{} set{} }
	public string StronglyTypedClassName { get{} set{} }
	public string StronglyTypedFileName { get{} set{} }
	public bool PublicClass { get{} set{} }
	public bool NeverLockTypeAssemblies { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


public class ResolveVCProjectOutput : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public ResolveVCProjectOutput() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get{} set{} }
	public string Configuration { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem Override { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ResolvedOutputPaths { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ResolvedImportLibraryPaths { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem SolutionFile { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


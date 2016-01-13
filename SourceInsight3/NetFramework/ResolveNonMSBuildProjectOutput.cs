public class ResolveNonMSBuildProjectOutput : ResolveProjectBase, Microsoft.Build.Framework.ITask
{

	// Constructors
	public ResolveNonMSBuildProjectOutput() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string PreresolvedProjectOutputs { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ResolvedOutputPaths { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] UnresolvedProjectReferences { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


public class AssignProjectConfiguration : ResolveProjectBase, Microsoft.Build.Framework.ITask
{

	// Constructors
	public AssignProjectConfiguration() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SolutionConfigurationContents { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] AssignedProjects { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] UnassignedProjects { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


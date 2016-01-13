public class ResolveNativeReference : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public ResolveNativeReference() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] NativeReferences { get{} set{} }
	public string[] AdditionalSearchPaths { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ContainingReferenceFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ContainedPrerequisiteAssemblies { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ContainedComComponents { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ContainedTypeLibraries { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ContainedLooseTlbFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ContainedLooseEtcFiles { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


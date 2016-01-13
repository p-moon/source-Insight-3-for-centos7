public class ResolveManifestFiles : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public ResolveManifestFiles() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem EntryPoint { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ExtraFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Files { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ManagedAssemblies { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] NativeAssemblies { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] OutputAssemblies { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] OutputFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] PublishFiles { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] SatelliteAssemblies { get{} set{} }
	public string TargetCulture { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


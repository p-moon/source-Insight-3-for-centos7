public class GenerateManifestBase : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ITask
{

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string AssemblyName { get{} set{} }
	public string AssemblyVersion { get{} set{} }
	public string Description { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem EntryPoint { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem InputManifest { get{} set{} }
	public int MaxTargetPath { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem OutputManifest { get{} set{} }
	public string Platform { get{} set{} }
	public string TargetCulture { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
}


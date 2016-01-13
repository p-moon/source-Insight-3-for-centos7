public class GenerateTrustInfo : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public GenerateTrustInfo() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem BaseManifest { get{} set{} }
	public string ExcludedPermissions { get{} set{} }
	public string TargetZone { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ApplicationDependencies { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem TrustInfoFile { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


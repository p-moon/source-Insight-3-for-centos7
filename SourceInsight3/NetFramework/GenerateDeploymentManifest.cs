public class GenerateDeploymentManifest : GenerateManifestBase, Microsoft.Build.Framework.ITask
{

	// Constructors
	public GenerateDeploymentManifest() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string DeploymentUrl { get{} set{} }
	public bool DisallowUrlActivation { get{} set{} }
	public bool Install { get{} set{} }
	public string MinimumRequiredVersion { get{} set{} }
	public bool MapFileExtensions { get{} set{} }
	public string Product { get{} set{} }
	public string Publisher { get{} set{} }
	public string SupportUrl { get{} set{} }
	public bool TrustUrlParameters { get{} set{} }
	public bool UpdateEnabled { get{} set{} }
	public int UpdateInterval { get{} set{} }
	public string UpdateMode { get{} set{} }
	public string UpdateUnit { get{} set{} }
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


public class CreateManifestResourceName : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Methods
	public virtual bool Execute() {}
	public static string MakeValidEverettIdentifier(string name) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] ResourceFiles { get{} set{} }
	public string RootNamespace { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ManifestResourceNames { get{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


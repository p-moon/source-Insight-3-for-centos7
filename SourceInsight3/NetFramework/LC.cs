public class LC : ToolTaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public LC() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.ITaskItem[] Sources { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem OutputLicense { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem LicenseTarget { get{} set{} }
	public string OutputDirectory { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] ReferencedAssemblies { get{} set{} }
	public bool NoLogo { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public int ExitCode { get{} }
	public string ToolPath { get{} set{} }
	public int Timeout { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


public class AspNetCompiler : ToolTaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public AspNetCompiler() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowPartiallyTrustedCallers { get{} set{} }
	public bool DelaySign { get{} set{} }
	public bool FixedNames { get{} set{} }
	public string KeyContainer { get{} set{} }
	public string KeyFile { get{} set{} }
	public string MetabasePath { get{} set{} }
	public string PhysicalPath { get{} set{} }
	public string TargetPath { get{} set{} }
	public string VirtualPath { get{} set{} }
	public bool Updateable { get{} set{} }
	public bool Force { get{} set{} }
	public bool Debug { get{} set{} }
	public bool Clean { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public int ExitCode { get{} }
	public string ToolPath { get{} set{} }
	public int Timeout { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


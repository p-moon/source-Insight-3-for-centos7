public class FormatVersion : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public FormatVersion() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string OutputVersion { get{} set{} }
	public string FormatType { get{} set{} }
	public int Revision { get{} set{} }
	public string Version { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


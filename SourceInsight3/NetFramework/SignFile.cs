public class SignFile : Microsoft.Build.Utilities.Task, Microsoft.Build.Framework.ITask
{

	// Constructors
	public SignFile() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CertificateThumbprint { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem SigningTarget { get{} set{} }
	public string TimestampUrl { get{} set{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
}


public class ResolveKeySource : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public ResolveKeySource() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string KeyFile { get{} set{} }
	public string CertificateThumbprint { get{} set{} }
	public string CertificateFile { get{} set{} }
	public bool SuppressAutoClosePasswordPrompt { get{} set{} }
	public bool ShowImportDialogDespitePreviousFailures { get{} set{} }
	public int AutoClosePasswordPromptTimeout { get{} set{} }
	public int AutoClosePasswordPromptShow { get{} set{} }
	public string ResolvedThumbprint { get{} set{} }
	public string ResolvedKeyContainer { get{} set{} }
	public string ResolvedKeyFile { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


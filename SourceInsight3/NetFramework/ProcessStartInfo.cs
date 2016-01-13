public class ProcessStartInfo
{

	// Constructors
	public ProcessStartInfo() {}
	public ProcessStartInfo(string fileName) {}
	public ProcessStartInfo(string fileName, string arguments) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Verb { get{} set{} }
	public string Arguments { get{} set{} }
	public bool CreateNoWindow { get{} set{} }
	public System.Collections.Specialized.StringDictionary EnvironmentVariables { get{} }
	public bool RedirectStandardInput { get{} set{} }
	public bool RedirectStandardOutput { get{} set{} }
	public bool RedirectStandardError { get{} set{} }
	public System.Text.Encoding StandardErrorEncoding { get{} set{} }
	public System.Text.Encoding StandardOutputEncoding { get{} set{} }
	public bool UseShellExecute { get{} set{} }
	public string[] Verbs { get{} }
	public string UserName { get{} set{} }
	public System.Security.SecureString Password { get{} set{} }
	public string Domain { get{} set{} }
	public bool LoadUserProfile { get{} set{} }
	public string FileName { get{} set{} }
	public string WorkingDirectory { get{} set{} }
	public bool ErrorDialog { get{} set{} }
	public System.IntPtr ErrorDialogParentHandle { get{} set{} }
	public ProcessWindowStyle WindowStyle { get{} set{} }
}


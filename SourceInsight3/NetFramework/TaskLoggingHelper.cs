public class TaskLoggingHelper : System.MarshalByRefObject
{

	// Constructors
	public TaskLoggingHelper(Microsoft.Build.Framework.ITask taskInstance) {}

	// Methods
	public string ExtractMessageCode(string messageout , System.String& messageWithoutCodePrefix) {}
	public virtual string FormatResourceString(string resourceName, object[] args) {}
	public virtual string FormatString(string unformatted, object[] args) {}
	public void LogMessage(string message, object[] messageArgs) {}
	public void LogMessage(Microsoft.Build.Framework.MessageImportance importance, string message, object[] messageArgs) {}
	public void LogMessageFromResources(string messageResourceName, object[] messageArgs) {}
	public void LogMessageFromResources(Microsoft.Build.Framework.MessageImportance importance, string messageResourceName, object[] messageArgs) {}
	public void LogExternalProjectStarted(string message, string helpKeyword, string projectFile, string targetNames) {}
	public void LogExternalProjectFinished(string message, string helpKeyword, string projectFile, bool succeeded) {}
	public void LogCommandLine(string commandLine) {}
	public void LogCommandLine(Microsoft.Build.Framework.MessageImportance importance, string commandLine) {}
	public void LogError(string message, object[] messageArgs) {}
	public void LogError(string subcategory, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, object[] messageArgs) {}
	public void LogErrorFromResources(string messageResourceName, object[] messageArgs) {}
	public void LogErrorFromResources(string subcategoryResourceName, string errorCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, object[] messageArgs) {}
	public void LogErrorWithCodeFromResources(string messageResourceName, object[] messageArgs) {}
	public void LogErrorWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, object[] messageArgs) {}
	public void LogErrorFromException(System.Exception exception) {}
	public void LogErrorFromException(System.Exception exception, bool showStackTrace) {}
	public void LogErrorFromException(System.Exception exception, bool showStackTrace, bool showDetail, string file) {}
	public void LogWarning(string message, object[] messageArgs) {}
	public void LogWarning(string subcategory, string warningCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, object[] messageArgs) {}
	public void LogWarningFromResources(string messageResourceName, object[] messageArgs) {}
	public void LogWarningFromResources(string subcategoryResourceName, string warningCode, string helpKeyword, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, object[] messageArgs) {}
	public void LogWarningWithCodeFromResources(string messageResourceName, object[] messageArgs) {}
	public void LogWarningWithCodeFromResources(string subcategoryResourceName, string file, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string messageResourceName, object[] messageArgs) {}
	public void LogWarningFromException(System.Exception exception) {}
	public void LogWarningFromException(System.Exception exception, bool showStackTrace) {}
	public bool LogMessagesFromFile(string fileName) {}
	public bool LogMessagesFromFile(string fileName, Microsoft.Build.Framework.MessageImportance messageImportance) {}
	public bool LogMessagesFromStream(System.IO.TextReader stream, Microsoft.Build.Framework.MessageImportance messageImportance) {}
	public bool LogMessageFromText(string lineOfText, Microsoft.Build.Framework.MessageImportance messageImportance) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Resources.ResourceManager TaskResources { get{} set{} }
	public string HelpKeywordPrefix { get{} set{} }
	public bool HasLoggedErrors { get{} }
}


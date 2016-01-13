public interface IBuildEngine
{

	// Methods
	public abstract virtual void LogErrorEvent(BuildErrorEventArgs e) {}
	public abstract virtual void LogWarningEvent(BuildWarningEventArgs e) {}
	public abstract virtual void LogMessageEvent(BuildMessageEventArgs e) {}
	public abstract virtual void LogCustomEvent(CustomBuildEventArgs e) {}
	public abstract virtual bool BuildProjectFile(string projectFileName, string[] targetNames, System.Collections.IDictionary globalProperties, System.Collections.IDictionary targetOutputs) {}

	// Properties
	public bool ContinueOnError { get{} }
	public int LineNumberOfTaskNode { get{} }
	public int ColumnNumberOfTaskNode { get{} }
	public string ProjectFileOfTaskNode { get{} }
}


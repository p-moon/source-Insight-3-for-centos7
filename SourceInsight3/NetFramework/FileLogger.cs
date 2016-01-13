public class FileLogger : ConsoleLogger, Microsoft.Build.Framework.ILogger
{

	// Constructors
	public FileLogger() {}

	// Methods
	public virtual void Initialize(Microsoft.Build.Framework.IEventSource eventSource) {}
	public virtual void Shutdown() {}
	public void ApplyParameter(string parameterName, string parameterValue) {}
	public void BuildStartedHandler(object sender, Microsoft.Build.Framework.BuildStartedEventArgs e) {}
	public void BuildFinishedHandler(object sender, Microsoft.Build.Framework.BuildFinishedEventArgs e) {}
	public void ProjectStartedHandler(object sender, Microsoft.Build.Framework.ProjectStartedEventArgs e) {}
	public void ProjectFinishedHandler(object sender, Microsoft.Build.Framework.ProjectFinishedEventArgs e) {}
	public void TargetStartedHandler(object sender, Microsoft.Build.Framework.TargetStartedEventArgs e) {}
	public void TargetFinishedHandler(object sender, Microsoft.Build.Framework.TargetFinishedEventArgs e) {}
	public void TaskStartedHandler(object sender, Microsoft.Build.Framework.TaskStartedEventArgs e) {}
	public void TaskFinishedHandler(object sender, Microsoft.Build.Framework.TaskFinishedEventArgs e) {}
	public void ErrorHandler(object sender, Microsoft.Build.Framework.BuildErrorEventArgs e) {}
	public void WarningHandler(object sender, Microsoft.Build.Framework.BuildWarningEventArgs e) {}
	public void MessageHandler(object sender, Microsoft.Build.Framework.BuildMessageEventArgs e) {}
	public void CustomEventHandler(object sender, Microsoft.Build.Framework.CustomBuildEventArgs e) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get{} set{} }
	public string Parameters { get{} set{} }
	public bool SkipProjectStartedText { get{} set{} }
	public bool ShowSummary { get{} set{} }
}


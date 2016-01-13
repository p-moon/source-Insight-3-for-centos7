public interface IEventSource
{

	// Events
	public event Microsoft.Build.Framework.BuildMessageEventHandler MessageRaised;
	public event Microsoft.Build.Framework.BuildErrorEventHandler ErrorRaised;
	public event Microsoft.Build.Framework.BuildWarningEventHandler WarningRaised;
	public event Microsoft.Build.Framework.BuildStartedEventHandler BuildStarted;
	public event Microsoft.Build.Framework.BuildFinishedEventHandler BuildFinished;
	public event Microsoft.Build.Framework.ProjectStartedEventHandler ProjectStarted;
	public event Microsoft.Build.Framework.ProjectFinishedEventHandler ProjectFinished;
	public event Microsoft.Build.Framework.TargetStartedEventHandler TargetStarted;
	public event Microsoft.Build.Framework.TargetFinishedEventHandler TargetFinished;
	public event Microsoft.Build.Framework.TaskStartedEventHandler TaskStarted;
	public event Microsoft.Build.Framework.TaskFinishedEventHandler TaskFinished;
	public event Microsoft.Build.Framework.CustomBuildEventHandler CustomEventRaised;
	public event Microsoft.Build.Framework.BuildStatusEventHandler StatusEventRaised;
	public event Microsoft.Build.Framework.AnyEventHandler AnyEventRaised;
}


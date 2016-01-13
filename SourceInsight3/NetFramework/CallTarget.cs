public class CallTarget : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public CallTarget() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] Targets { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get{} }
	public bool RunEachTargetSeparately { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


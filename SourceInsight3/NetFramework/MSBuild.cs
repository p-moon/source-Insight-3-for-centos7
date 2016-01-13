public class MSBuild : TaskExtension, Microsoft.Build.Framework.ITask
{

	// Constructors
	public MSBuild() {}

	// Methods
	public virtual bool Execute() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] Properties { get{} set{} }
	public string[] Targets { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] Projects { get{} set{} }
	public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get{} }
	public bool RebaseOutputs { get{} set{} }
	public bool StopOnFirstFailure { get{} set{} }
	public bool RunEachTargetSeparately { get{} set{} }
	public Microsoft.Build.Utilities.TaskLoggingHelper Log { get{} }
	public Microsoft.Build.Framework.IBuildEngine BuildEngine { get{} set{} }
	public Microsoft.Build.Framework.ITaskHost HostObject { get{} set{} }
}


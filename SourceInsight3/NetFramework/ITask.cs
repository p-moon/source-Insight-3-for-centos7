public interface ITask
{

	// Methods
	public abstract virtual bool Execute() {}

	// Properties
	public IBuildEngine BuildEngine { get{} set{} }
	public ITaskHost HostObject { get{} set{} }
}


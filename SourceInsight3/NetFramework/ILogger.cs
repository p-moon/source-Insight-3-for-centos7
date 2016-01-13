public interface ILogger
{

	// Methods
	public abstract virtual void Initialize(IEventSource eventSource) {}
	public abstract virtual void Shutdown() {}

	// Properties
	public LoggerVerbosity Verbosity { get{} set{} }
	public string Parameters { get{} set{} }
}


public class ProcessInfo
{

	// Constructors
	public ProcessInfo(System.DateTime startTime, System.TimeSpan age, int processID, int requestCount, ProcessStatus status, ProcessShutdownReason shutdownReason, int peakMemoryUsed) {}
	public ProcessInfo() {}

	// Methods
	public void SetAll(System.DateTime startTime, System.TimeSpan age, int processID, int requestCount, ProcessStatus status, ProcessShutdownReason shutdownReason, int peakMemoryUsed) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime StartTime { get{} }
	public System.TimeSpan Age { get{} }
	public int ProcessID { get{} }
	public int RequestCount { get{} }
	public ProcessStatus Status { get{} }
	public ProcessShutdownReason ShutdownReason { get{} }
	public int PeakMemoryUsed { get{} }
}


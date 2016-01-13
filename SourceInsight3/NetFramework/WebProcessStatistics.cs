public class WebProcessStatistics
{

	// Constructors
	public WebProcessStatistics() {}

	// Methods
	public virtual void FormatToString(WebEventFormatter formatter) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime ProcessStartTime { get{} }
	public int ThreadCount { get{} }
	public long WorkingSet { get{} }
	public long PeakWorkingSet { get{} }
	public long ManagedHeapSize { get{} }
	public int AppDomainCount { get{} }
	public int RequestsExecuting { get{} }
	public int RequestsQueued { get{} }
	public int RequestsRejected { get{} }
}


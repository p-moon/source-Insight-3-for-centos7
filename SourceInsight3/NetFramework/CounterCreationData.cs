public class CounterCreationData
{

	// Constructors
	public CounterCreationData() {}
	public CounterCreationData(string counterName, string counterHelp, PerformanceCounterType counterType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PerformanceCounterType CounterType { get{} set{} }
	public string CounterName { get{} set{} }
	public string CounterHelp { get{} set{} }
}


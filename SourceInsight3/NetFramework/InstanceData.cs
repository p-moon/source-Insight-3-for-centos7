public class InstanceData
{

	// Constructors
	public InstanceData(string instanceName, CounterSample sample) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string InstanceName { get{} }
	public CounterSample Sample { get{} }
	public long RawValue { get{} }
}


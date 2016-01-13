public class Int64Aggregator : System.ValueType
{

	// Methods
	public void Create() {}
	public void Sum(long value) {}
	public void Average(long value) {}
	public void Minimum(long value) {}
	public void Maximum(long value) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public long SumResult { get{} }
	public long AverageResult { get{} }
	public long MinimumResult { get{} }
	public long MaximumResult { get{} }
	public bool IsEmpty { get{} }
}


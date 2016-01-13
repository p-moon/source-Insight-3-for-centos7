public class Int32Aggregator : System.ValueType
{

	// Methods
	public void Create() {}
	public void Sum(int value) {}
	public void Average(int value) {}
	public void Minimum(int value) {}
	public void Maximum(int value) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public int SumResult { get{} }
	public int AverageResult { get{} }
	public int MinimumResult { get{} }
	public int MaximumResult { get{} }
	public bool IsEmpty { get{} }
}


public class DoubleAggregator : System.ValueType
{

	// Methods
	public void Create() {}
	public void Sum(double value) {}
	public void Average(double value) {}
	public void Minimum(double value) {}
	public void Maximum(double value) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public double SumResult { get{} }
	public double AverageResult { get{} }
	public double MinimumResult { get{} }
	public double MaximumResult { get{} }
	public bool IsEmpty { get{} }
}


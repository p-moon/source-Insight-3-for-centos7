public class DecimalAggregator : System.ValueType
{

	// Methods
	public void Create() {}
	public void Sum(decimal value) {}
	public void Average(decimal value) {}
	public void Minimum(decimal value) {}
	public void Maximum(decimal value) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public decimal SumResult { get{} }
	public decimal AverageResult { get{} }
	public decimal MinimumResult { get{} }
	public decimal MaximumResult { get{} }
	public bool IsEmpty { get{} }
}


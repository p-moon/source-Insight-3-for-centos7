public class CounterSample : System.ValueType
{

	// Constructors
	public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType) {}
	public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType, long counterTimeStamp) {}

	// Methods
	public static float Calculate(CounterSample counterSample) {}
	public static float Calculate(CounterSample counterSample, CounterSample nextCounterSample) {}
	public virtual bool Equals(object o) {}
	public bool Equals(CounterSample sample) {}
	public virtual int GetHashCode() {}
	public static bool op_Equality(CounterSample a, CounterSample b) {}
	public static bool op_Inequality(CounterSample a, CounterSample b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public CounterSample Empty;

	// Properties
	public long RawValue { get{} }
	public long BaseValue { get{} }
	public long SystemFrequency { get{} }
	public long CounterFrequency { get{} }
	public long CounterTimeStamp { get{} }
	public long TimeStamp { get{} }
	public long TimeStamp100nSec { get{} }
	public PerformanceCounterType CounterType { get{} }
}


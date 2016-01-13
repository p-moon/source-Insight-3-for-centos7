public class PerformanceCounterType : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public PerformanceCounterType NumberOfItems32;
	public PerformanceCounterType NumberOfItems64;
	public PerformanceCounterType NumberOfItemsHEX32;
	public PerformanceCounterType NumberOfItemsHEX64;
	public PerformanceCounterType RateOfCountsPerSecond32;
	public PerformanceCounterType RateOfCountsPerSecond64;
	public PerformanceCounterType CountPerTimeInterval32;
	public PerformanceCounterType CountPerTimeInterval64;
	public PerformanceCounterType RawFraction;
	public PerformanceCounterType RawBase;
	public PerformanceCounterType AverageTimer32;
	public PerformanceCounterType AverageBase;
	public PerformanceCounterType AverageCount64;
	public PerformanceCounterType SampleFraction;
	public PerformanceCounterType SampleCounter;
	public PerformanceCounterType SampleBase;
	public PerformanceCounterType CounterTimer;
	public PerformanceCounterType CounterTimerInverse;
	public PerformanceCounterType Timer100Ns;
	public PerformanceCounterType Timer100NsInverse;
	public PerformanceCounterType ElapsedTime;
	public PerformanceCounterType CounterMultiTimer;
	public PerformanceCounterType CounterMultiTimerInverse;
	public PerformanceCounterType CounterMultiTimer100Ns;
	public PerformanceCounterType CounterMultiTimer100NsInverse;
	public PerformanceCounterType CounterMultiBase;
	public PerformanceCounterType CounterDelta32;
	public PerformanceCounterType CounterDelta64;
}


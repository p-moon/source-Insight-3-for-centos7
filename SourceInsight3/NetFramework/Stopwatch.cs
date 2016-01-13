public class Stopwatch
{

	// Constructors
	public Stopwatch() {}

	// Methods
	public void Start() {}
	public static Stopwatch StartNew() {}
	public void Stop() {}
	public void Reset() {}
	public static long GetTimestamp() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public long Frequency;
	public bool IsHighResolution;

	// Properties
	public bool IsRunning { get{} }
	public System.TimeSpan Elapsed { get{} }
	public long ElapsedMilliseconds { get{} }
	public long ElapsedTicks { get{} }
}


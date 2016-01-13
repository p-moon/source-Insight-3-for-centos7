public class Interlocked
{

	// Methods
	public static T CompareExchange<T>(T& location1, T value, T comparand) {}
	public static T Exchange<T>(T& location1, T value) {}
	public static int Increment(System.Int32& location) {}
	public static long Increment(System.Int64& location) {}
	public static int Decrement(System.Int32& location) {}
	public static long Decrement(System.Int64& location) {}
	public static int Exchange(System.Int32& location1, int value) {}
	public static long Exchange(System.Int64& location1, long value) {}
	public static float Exchange(System.Single& location1, float value) {}
	public static double Exchange(System.Double& location1, double value) {}
	public static object Exchange(System.Object& location1, object value) {}
	public static System.IntPtr Exchange(System.IntPtr& location1, System.IntPtr value) {}
	public static int CompareExchange(System.Int32& location1, int value, int comparand) {}
	public static long CompareExchange(System.Int64& location1, long value, long comparand) {}
	public static float CompareExchange(System.Single& location1, float value, float comparand) {}
	public static double CompareExchange(System.Double& location1, double value, double comparand) {}
	public static object CompareExchange(System.Object& location1, object value, object comparand) {}
	public static System.IntPtr CompareExchange(System.IntPtr& location1, System.IntPtr value, System.IntPtr comparand) {}
	public static int Add(System.Int32& location1, int value) {}
	public static long Add(System.Int64& location1, long value) {}
	public static long Read(System.Int64& location) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


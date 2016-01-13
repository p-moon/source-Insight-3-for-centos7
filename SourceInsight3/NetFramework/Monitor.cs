public class Monitor
{

	// Methods
	public static void Enter(object obj) {}
	public static void Exit(object obj) {}
	public static bool TryEnter(object obj) {}
	public static bool TryEnter(object obj, int millisecondsTimeout) {}
	public static bool TryEnter(object obj, System.TimeSpan timeout) {}
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) {}
	public static bool Wait(object obj, System.TimeSpan timeout, bool exitContext) {}
	public static bool Wait(object obj, int millisecondsTimeout) {}
	public static bool Wait(object obj, System.TimeSpan timeout) {}
	public static bool Wait(object obj) {}
	public static void Pulse(object obj) {}
	public static void PulseAll(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


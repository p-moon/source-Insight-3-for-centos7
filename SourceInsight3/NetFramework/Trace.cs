public class Trace
{

	// Methods
	public static void Flush() {}
	public static void Close() {}
	public static void Assert(bool condition) {}
	public static void Assert(bool condition, string message) {}
	public static void Assert(bool condition, string message, string detailMessage) {}
	public static void Fail(string message) {}
	public static void Fail(string message, string detailMessage) {}
	public static void Refresh() {}
	public static void TraceInformation(string message) {}
	public static void TraceInformation(string format, object[] args) {}
	public static void TraceWarning(string message) {}
	public static void TraceWarning(string format, object[] args) {}
	public static void TraceError(string message) {}
	public static void TraceError(string format, object[] args) {}
	public static void Write(string message) {}
	public static void Write(object value) {}
	public static void Write(string message, string category) {}
	public static void Write(object value, string category) {}
	public static void WriteLine(string message) {}
	public static void WriteLine(object value) {}
	public static void WriteLine(string message, string category) {}
	public static void WriteLine(object value, string category) {}
	public static void WriteIf(bool condition, string message) {}
	public static void WriteIf(bool condition, object value) {}
	public static void WriteIf(bool condition, string message, string category) {}
	public static void WriteIf(bool condition, object value, string category) {}
	public static void WriteLineIf(bool condition, string message) {}
	public static void WriteLineIf(bool condition, object value) {}
	public static void WriteLineIf(bool condition, string message, string category) {}
	public static void WriteLineIf(bool condition, object value, string category) {}
	public static void Indent() {}
	public static void Unindent() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public TraceListenerCollection Listeners { get{} }
	public bool AutoFlush { get{} set{} }
	public bool UseGlobalLock { get{} set{} }
	public CorrelationManager CorrelationManager { get{} }
	public int IndentLevel { get{} set{} }
	public int IndentSize { get{} set{} }
}


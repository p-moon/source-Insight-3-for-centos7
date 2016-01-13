public class ScriptStream
{

	// Constructors
	public ScriptStream() {}

	// Methods
	public static void PrintStackTrace() {}
	public static void PrintStackTrace(System.Exception e) {}
	public static void Write(string str) {}
	public static void WriteLine(string str) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public System.IO.TextWriter Out;
	public System.IO.TextWriter Error;
}


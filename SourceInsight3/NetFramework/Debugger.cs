public class Debugger
{

	// Constructors
	public Debugger() {}

	// Methods
	public static void Log(int level, string category, string message) {}
	public static bool IsLogging() {}
	public static void Break() {}
	public static bool Launch() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string DefaultCategory;

	// Properties
	public bool IsAttached { get{} }
}


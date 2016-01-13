public class CmdLineOptionParser
{

	// Constructors
	public CmdLineOptionParser() {}

	// Methods
	public static bool IsSimpleOption(string option, string prefix) {}
	public static string IsArgumentOption(string option, string prefix) {}
	public static string IsArgumentOption(string option, string shortPrefix, string longPrefix) {}
	public static object IsBooleanOption(string option, string prefix) {}
	public static object IsBooleanOption(string option, string shortPrefix, string longPrefix) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


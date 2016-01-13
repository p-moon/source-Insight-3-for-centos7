public class CodeConnectAccess
{

	// Constructors
	public CodeConnectAccess(string allowScheme, int allowPort) {}

	// Methods
	public static CodeConnectAccess CreateOriginSchemeAccess(int allowPort) {}
	public static CodeConnectAccess CreateAnySchemeAccess(int allowPort) {}
	public virtual bool Equals(object o) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public int DefaultPort;
	public int OriginPort;
	public string OriginScheme;
	public string AnyScheme;

	// Properties
	public string Scheme { get{} }
	public int Port { get{} }
}


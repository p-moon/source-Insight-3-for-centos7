public class ENUM_SERVICE_STATUS
{

	// Constructors
	public ENUM_SERVICE_STATUS() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string serviceName;
	public string displayName;
	public int serviceType;
	public int currentState;
	public int controlsAccepted;
	public int win32ExitCode;
	public int serviceSpecificExitCode;
	public int checkPoint;
	public int waitHint;
}


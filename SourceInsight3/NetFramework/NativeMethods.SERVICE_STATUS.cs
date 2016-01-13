public class SERVICE_STATUS : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int serviceType;
	public int currentState;
	public int controlsAccepted;
	public int win32ExitCode;
	public int serviceSpecificExitCode;
	public int checkPoint;
	public int waitHint;
}


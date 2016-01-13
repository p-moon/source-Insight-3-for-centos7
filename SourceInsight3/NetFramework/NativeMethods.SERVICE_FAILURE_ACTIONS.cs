public class SERVICE_FAILURE_ACTIONS : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public uint dwResetPeriod;
	public System.IntPtr rebootMsg;
	public System.IntPtr command;
	public uint numActions;
	public SC_ACTION* actions;
}


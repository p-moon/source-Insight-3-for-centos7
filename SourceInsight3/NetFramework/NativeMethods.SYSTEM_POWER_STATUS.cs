public class SYSTEM_POWER_STATUS : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public byte ACLineStatus;
	public byte BatteryFlag;
	public byte BatteryLifePercent;
	public byte Reserved1;
	public int BatteryLifeTime;
	public int BatteryFullLifeTime;
}


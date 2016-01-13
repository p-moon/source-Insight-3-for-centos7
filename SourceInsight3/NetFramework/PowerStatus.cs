public class PowerStatus
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PowerLineStatus PowerLineStatus { get{} }
	public BatteryChargeStatus BatteryChargeStatus { get{} }
	public int BatteryFullLifetime { get{} }
	public float BatteryLifePercent { get{} }
	public int BatteryLifeRemaining { get{} }
}


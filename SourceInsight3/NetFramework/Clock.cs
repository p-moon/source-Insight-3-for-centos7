public class Clock
{

	// Constructors
	public Clock() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime LocalTime { get{} }
	public System.DateTime GmtTime { get{} }
	public int TickCount { get{} }
}


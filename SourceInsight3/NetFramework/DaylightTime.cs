public class DaylightTime
{

	// Constructors
	public DaylightTime(System.DateTime start, System.DateTime end, System.TimeSpan delta) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.DateTime Start { get{} }
	public System.DateTime End { get{} }
	public System.TimeSpan Delta { get{} }
}


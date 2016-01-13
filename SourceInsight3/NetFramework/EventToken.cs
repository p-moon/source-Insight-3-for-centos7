public class EventToken : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(EventToken obj) {}
	public static bool op_Equality(EventToken a, EventToken b) {}
	public static bool op_Inequality(EventToken a, EventToken b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public EventToken Empty;

	// Properties
	public int Token { get{} }
}


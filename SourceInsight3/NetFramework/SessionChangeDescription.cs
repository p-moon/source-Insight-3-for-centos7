public class SessionChangeDescription : System.ValueType
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public bool Equals(SessionChangeDescription changeDescription) {}
	public static bool op_Equality(SessionChangeDescription a, SessionChangeDescription b) {}
	public static bool op_Inequality(SessionChangeDescription a, SessionChangeDescription b) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public SessionChangeReason Reason { get{} }
	public int SessionId { get{} }
}


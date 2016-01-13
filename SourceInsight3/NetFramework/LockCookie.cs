public class LockCookie : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public bool Equals(LockCookie obj) {}
	public static bool op_Equality(LockCookie a, LockCookie b) {}
	public static bool op_Inequality(LockCookie a, LockCookie b) {}
	public virtual string ToString() {}
	public Type GetType() {}
}


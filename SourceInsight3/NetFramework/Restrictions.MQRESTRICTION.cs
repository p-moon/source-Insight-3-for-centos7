public class MQRESTRICTION
{

	// Constructors
	public MQRESTRICTION(int maxCount) {}

	// Methods
	public System.IntPtr GetNextValidPtr(int offset) {}
	public static int GetRestrictionSize() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int restrictionCount;
	public System.IntPtr restrinctions;
}


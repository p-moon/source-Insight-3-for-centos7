public class PDH_RAW_COUNTER
{

	// Constructors
	public PDH_RAW_COUNTER() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int CStatus;
	public long TimeStamp;
	public long FirstValue;
	public long SecondValue;
	public int MultiCount;
}


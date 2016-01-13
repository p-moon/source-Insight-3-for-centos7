public class ThreadWaitReason : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public ThreadWaitReason Executive;
	public ThreadWaitReason FreePage;
	public ThreadWaitReason PageIn;
	public ThreadWaitReason SystemAllocation;
	public ThreadWaitReason ExecutionDelay;
	public ThreadWaitReason Suspended;
	public ThreadWaitReason UserRequest;
	public ThreadWaitReason EventPairHigh;
	public ThreadWaitReason EventPairLow;
	public ThreadWaitReason LpcReceive;
	public ThreadWaitReason LpcReply;
	public ThreadWaitReason VirtualMemory;
	public ThreadWaitReason PageOut;
	public ThreadWaitReason Unknown;
}


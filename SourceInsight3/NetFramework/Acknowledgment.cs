public class Acknowledgment : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public Acknowledgment None;
	public Acknowledgment AccessDenied;
	public Acknowledgment BadDestinationQueue;
	public Acknowledgment BadEncryption;
	public Acknowledgment BadSignature;
	public Acknowledgment CouldNotEncrypt;
	public Acknowledgment HopCountExceeded;
	public Acknowledgment NotTransactionalQueue;
	public Acknowledgment NotTransactionalMessage;
	public Acknowledgment Purged;
	public Acknowledgment QueueDeleted;
	public Acknowledgment QueueExceedMaximumSize;
	public Acknowledgment QueuePurged;
	public Acknowledgment ReachQueue;
	public Acknowledgment ReachQueueTimeout;
	public Acknowledgment ReceiveTimeout;
	public Acknowledgment Receive;
}


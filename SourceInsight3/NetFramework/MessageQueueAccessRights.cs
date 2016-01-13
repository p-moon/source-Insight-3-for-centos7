public class MessageQueueAccessRights : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public MessageQueueAccessRights DeleteMessage;
	public MessageQueueAccessRights PeekMessage;
	public MessageQueueAccessRights WriteMessage;
	public MessageQueueAccessRights DeleteJournalMessage;
	public MessageQueueAccessRights SetQueueProperties;
	public MessageQueueAccessRights GetQueueProperties;
	public MessageQueueAccessRights DeleteQueue;
	public MessageQueueAccessRights GetQueuePermissions;
	public MessageQueueAccessRights ChangeQueuePermissions;
	public MessageQueueAccessRights TakeQueueOwnership;
	public MessageQueueAccessRights ReceiveMessage;
	public MessageQueueAccessRights ReceiveJournalMessage;
	public MessageQueueAccessRights GenericRead;
	public MessageQueueAccessRights GenericWrite;
	public MessageQueueAccessRights FullControl;
}


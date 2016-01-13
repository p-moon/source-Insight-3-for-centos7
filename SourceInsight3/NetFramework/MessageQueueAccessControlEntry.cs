public class MessageQueueAccessControlEntry : AccessControlEntry
{

	// Constructors
	public MessageQueueAccessControlEntry(Trustee trustee, MessageQueueAccessRights rights) {}
	public MessageQueueAccessControlEntry(Trustee trustee, MessageQueueAccessRights rights, AccessControlEntryType entryType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MessageQueueAccessRights MessageQueueAccessRights { get{} set{} }
	public AccessControlEntryType EntryType { get{} set{} }
	public GenericAccessRights GenericAccessRights { get{} set{} }
	public StandardAccessRights StandardAccessRights { get{} set{} }
	public Trustee Trustee { get{} set{} }
}


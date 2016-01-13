public class AccessControlEntry
{

	// Constructors
	public AccessControlEntry() {}
	public AccessControlEntry(Trustee trustee) {}
	public AccessControlEntry(Trustee trustee, GenericAccessRights genericAccessRights, StandardAccessRights standardAccessRights, AccessControlEntryType entryType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public AccessControlEntryType EntryType { get{} set{} }
	public GenericAccessRights GenericAccessRights { get{} set{} }
	public StandardAccessRights StandardAccessRights { get{} set{} }
	public Trustee Trustee { get{} set{} }
}


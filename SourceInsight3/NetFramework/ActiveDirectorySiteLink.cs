public class ActiveDirectorySiteLink : System.IDisposable
{

	// Constructors
	public ActiveDirectorySiteLink(DirectoryContext context, string siteLinkName) {}
	public ActiveDirectorySiteLink(DirectoryContext context, string siteLinkName, ActiveDirectoryTransportType transport) {}
	public ActiveDirectorySiteLink(DirectoryContext context, string siteLinkName, ActiveDirectoryTransportType transport, ActiveDirectorySchedule schedule) {}

	// Methods
	public static ActiveDirectorySiteLink FindByName(DirectoryContext context, string siteLinkName) {}
	public static ActiveDirectorySiteLink FindByName(DirectoryContext context, string siteLinkName, ActiveDirectoryTransportType transport) {}
	public void Save() {}
	public void Delete() {}
	public virtual string ToString() {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public virtual void Dispose() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public ActiveDirectoryTransportType TransportType { get{} }
	public ActiveDirectorySiteCollection Sites { get{} }
	public int Cost { get{} set{} }
	public System.TimeSpan ReplicationInterval { get{} set{} }
	public bool ReciprocalReplicationEnabled { get{} set{} }
	public bool NotificationEnabled { get{} set{} }
	public bool DataCompressionEnabled { get{} set{} }
	public ActiveDirectorySchedule InterSiteReplicationSchedule { get{} set{} }
}


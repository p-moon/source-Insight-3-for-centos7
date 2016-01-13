public class ReplicationConnection : System.IDisposable
{

	// Constructors
	public ReplicationConnection(DirectoryContext context, string name, DirectoryServer sourceServer) {}
	public ReplicationConnection(DirectoryContext context, string name, DirectoryServer sourceServer, ActiveDirectorySchedule schedule) {}
	public ReplicationConnection(DirectoryContext context, string name, DirectoryServer sourceServer, ActiveDirectoryTransportType transport) {}
	public ReplicationConnection(DirectoryContext context, string name, DirectoryServer sourceServer, ActiveDirectorySchedule schedule, ActiveDirectoryTransportType transport) {}

	// Methods
	public static ReplicationConnection FindByName(DirectoryContext context, string name) {}
	public virtual void Dispose() {}
	public void Delete() {}
	public void Save() {}
	public virtual string ToString() {}
	public System.DirectoryServices.DirectoryEntry GetDirectoryEntry() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Name { get{} }
	public string SourceServer { get{} }
	public string DestinationServer { get{} }
	public bool Enabled { get{} set{} }
	public ActiveDirectoryTransportType TransportType { get{} }
	public bool GeneratedByKcc { get{} set{} }
	public bool ReciprocalReplicationEnabled { get{} set{} }
	public NotificationStatus ChangeNotificationStatus { get{} set{} }
	public bool DataCompressionEnabled { get{} set{} }
	public bool ReplicationScheduleOwnedByUser { get{} set{} }
	public ReplicationSpan ReplicationSpan { get{} }
	public ActiveDirectorySchedule ReplicationSchedule { get{} set{} }
}


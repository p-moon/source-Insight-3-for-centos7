public class ReplicationNeighborOptions : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public long value__;
	public ReplicationNeighborOptions Writeable;
	public ReplicationNeighborOptions SyncOnStartup;
	public ReplicationNeighborOptions ScheduledSync;
	public ReplicationNeighborOptions UseInterSiteTransport;
	public ReplicationNeighborOptions TwoWaySync;
	public ReplicationNeighborOptions ReturnObjectParent;
	public ReplicationNeighborOptions FullSyncInProgress;
	public ReplicationNeighborOptions FullSyncNextPacket;
	public ReplicationNeighborOptions NeverSynced;
	public ReplicationNeighborOptions Preempted;
	public ReplicationNeighborOptions IgnoreChangeNotifications;
	public ReplicationNeighborOptions DisableScheduledSync;
	public ReplicationNeighborOptions CompressChanges;
	public ReplicationNeighborOptions NoChangeNotifications;
	public ReplicationNeighborOptions PartialAttributeSet;
}


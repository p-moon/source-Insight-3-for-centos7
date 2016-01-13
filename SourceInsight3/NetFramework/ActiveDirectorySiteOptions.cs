public class ActiveDirectorySiteOptions : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
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
	public ActiveDirectorySiteOptions None;
	public ActiveDirectorySiteOptions AutoTopologyDisabled;
	public ActiveDirectorySiteOptions TopologyCleanupDisabled;
	public ActiveDirectorySiteOptions AutoMinimumHopDisabled;
	public ActiveDirectorySiteOptions StaleServerDetectDisabled;
	public ActiveDirectorySiteOptions AutoInterSiteTopologyDisabled;
	public ActiveDirectorySiteOptions GroupMembershipCachingEnabled;
	public ActiveDirectorySiteOptions ForceKccWindows2003Behavior;
	public ActiveDirectorySiteOptions UseWindows2000IstgElection;
	public ActiveDirectorySiteOptions RandomBridgeHeaderServerSelectionDisabled;
	public ActiveDirectorySiteOptions UseHashingForReplicationSchedule;
	public ActiveDirectorySiteOptions RedundantServerTopologyEnabled;
}


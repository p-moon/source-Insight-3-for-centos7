public class UpdateCheckInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UpdateAvailable { get{} }
	public System.Version AvailableVersion { get{} }
	public bool IsUpdateRequired { get{} }
	public System.Version MinimumRequiredVersion { get{} }
	public long UpdateSizeBytes { get{} }
}


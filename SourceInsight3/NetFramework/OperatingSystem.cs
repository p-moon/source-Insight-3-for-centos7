public class OperatingSystem : ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public OperatingSystem(PlatformID platform, Version version) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual object Clone() {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public PlatformID Platform { get{} }
	public string ServicePack { get{} }
	public Version Version { get{} }
	public string VersionString { get{} }
}


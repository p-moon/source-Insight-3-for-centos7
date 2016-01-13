public class ObjRef : System.Runtime.Serialization.IObjectReference, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ObjRef(System.MarshalByRefObject o, Type requestedType) {}
	public ObjRef() {}

	// Methods
	public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public bool IsFromThisProcess() {}
	public bool IsFromThisAppDomain() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string URI { get{} set{} }
	public IRemotingTypeInfo TypeInfo { get{} set{} }
	public IEnvoyInfo EnvoyInfo { get{} set{} }
	public IChannelInfo ChannelInfo { get{} set{} }
}


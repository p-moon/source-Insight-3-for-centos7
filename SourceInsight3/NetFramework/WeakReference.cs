public class WeakReference : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public WeakReference(object target) {}
	public WeakReference(object target, bool trackResurrection) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsAlive { get{} }
	public bool TrackResurrection { get{} }
	public object Target { get{} set{} }
}


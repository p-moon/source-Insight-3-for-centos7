public class LogicalCallContext : System.Runtime.Serialization.ISerializable, System.ICloneable
{

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual object Clone() {}
	public void FreeNamedDataSlot(string name) {}
	public object GetData(string name) {}
	public void SetData(string name, object data) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool HasInfo { get{} }
}


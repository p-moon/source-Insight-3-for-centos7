public class RealProxy
{

	// Methods
	public static void SetStubData(RealProxy rp, object stubData) {}
	public static object GetStubData(RealProxy rp) {}
	public Type GetProxiedType() {}
	public virtual System.IntPtr GetCOMIUnknown(bool fIsMarshalled) {}
	public System.Runtime.Remoting.Activation.IConstructionReturnMessage InitializeServerObject(System.Runtime.Remoting.Activation.IConstructionCallMessage ctorMsg) {}
	public abstract virtual System.Runtime.Remoting.Messaging.IMessage Invoke(System.Runtime.Remoting.Messaging.IMessage msg) {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void SetCOMIUnknown(System.IntPtr i) {}
	public virtual System.IntPtr SupportsInterface(System.Guid& iid) {}
	public virtual object GetTransparentProxy() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


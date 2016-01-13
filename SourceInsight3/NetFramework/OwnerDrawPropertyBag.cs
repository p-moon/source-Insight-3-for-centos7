public class OwnerDrawPropertyBag : System.MarshalByRefObject, System.Runtime.Serialization.ISerializable
{

	// Methods
	public virtual bool IsEmpty() {}
	public static OwnerDrawPropertyBag Copy(OwnerDrawPropertyBag value) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Font Font { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
}


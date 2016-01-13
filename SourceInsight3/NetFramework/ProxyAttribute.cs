public class ProxyAttribute : System.Attribute, System.Runtime.InteropServices._Attribute, System.Runtime.Remoting.Contexts.IContextAttribute
{

	// Constructors
	public ProxyAttribute() {}

	// Methods
	public virtual System.MarshalByRefObject CreateInstance(Type serverType) {}
	public virtual RealProxy CreateProxy(System.Runtime.Remoting.ObjRef objRef, Type serverType, object serverObject, System.Runtime.Remoting.Contexts.Context serverContext) {}
	public virtual bool IsContextOK(System.Runtime.Remoting.Contexts.Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) {}
	public virtual void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public object TypeId { get{} }
}


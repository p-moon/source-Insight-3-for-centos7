public class SoapRpcServiceAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SoapRpcServiceAttribute() {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public SoapServiceRoutingStyle RoutingStyle { get{} set{} }
	public System.Web.Services.Description.SoapBindingUse Use { get{} set{} }
	public object TypeId { get{} }
}


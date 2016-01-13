public class SoapDocumentServiceAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SoapDocumentServiceAttribute() {}
	public SoapDocumentServiceAttribute(System.Web.Services.Description.SoapBindingUse use) {}
	public SoapDocumentServiceAttribute(System.Web.Services.Description.SoapBindingUse use, SoapParameterStyle paramStyle) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Web.Services.Description.SoapBindingUse Use { get{} set{} }
	public SoapParameterStyle ParameterStyle { get{} set{} }
	public SoapServiceRoutingStyle RoutingStyle { get{} set{} }
	public object TypeId { get{} }
}


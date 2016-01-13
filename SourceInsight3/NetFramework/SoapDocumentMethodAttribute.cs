public class SoapDocumentMethodAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SoapDocumentMethodAttribute() {}
	public SoapDocumentMethodAttribute(string action) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Action { get{} set{} }
	public bool OneWay { get{} set{} }
	public string RequestNamespace { get{} set{} }
	public string ResponseNamespace { get{} set{} }
	public string RequestElementName { get{} set{} }
	public string ResponseElementName { get{} set{} }
	public System.Web.Services.Description.SoapBindingUse Use { get{} set{} }
	public SoapParameterStyle ParameterStyle { get{} set{} }
	public string Binding { get{} set{} }
	public object TypeId { get{} }
}


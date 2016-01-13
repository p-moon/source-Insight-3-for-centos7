public class WebServiceBindingAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public WebServiceBindingAttribute() {}
	public WebServiceBindingAttribute(string name) {}
	public WebServiceBindingAttribute(string name, string ns) {}
	public WebServiceBindingAttribute(string name, string ns, string location) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public WsiProfiles ConformsTo { get{} set{} }
	public bool EmitConformanceClaims { get{} set{} }
	public string Location { get{} set{} }
	public string Name { get{} set{} }
	public string Namespace { get{} set{} }
	public object TypeId { get{} }
}


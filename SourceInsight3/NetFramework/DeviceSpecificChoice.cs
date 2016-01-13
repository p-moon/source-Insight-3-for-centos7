public class DeviceSpecificChoice : System.Web.UI.IParserAccessor, System.Web.UI.IAttributeAccessor
{

	// Constructors
	public DeviceSpecificChoice() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Filter { get{} set{} }
	public string Argument { get{} set{} }
	public string Xmlns { get{} set{} }
	public System.Collections.IDictionary Contents { get{} }
	public System.Collections.IDictionary Templates { get{} }
	public bool HasTemplates { get{} }
}


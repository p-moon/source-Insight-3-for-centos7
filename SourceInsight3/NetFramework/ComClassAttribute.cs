public class ComClassAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ComClassAttribute() {}
	public ComClassAttribute(string _ClassID) {}
	public ComClassAttribute(string _ClassID, string _InterfaceID) {}
	public ComClassAttribute(string _ClassID, string _InterfaceID, string _EventId) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ClassID { get{} }
	public string InterfaceID { get{} }
	public string EventID { get{} }
	public bool InterfaceShadows { get{} set{} }
	public object TypeId { get{} }
}


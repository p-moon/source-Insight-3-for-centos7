public class ConnectionPoint
{

	// Methods
	public virtual bool GetEnabled(System.Web.UI.Control control) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string DefaultID;

	// Properties
	public bool AllowsMultipleConnections { get{} }
	public Type ControlType { get{} }
	public Type InterfaceType { get{} }
	public string ID { get{} }
	public string DisplayName { get{} }
}


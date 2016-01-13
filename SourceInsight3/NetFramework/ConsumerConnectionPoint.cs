public class ConsumerConnectionPoint : ConnectionPoint
{

	// Constructors
	public ConsumerConnectionPoint(System.Reflection.MethodInfo callbackMethod, Type interfaceType, Type controlType, string displayName, string id, bool allowsMultipleConnections) {}

	// Methods
	public virtual void SetObject(System.Web.UI.Control control, object data) {}
	public virtual bool SupportsConnection(System.Web.UI.Control control, ConnectionInterfaceCollection secondaryInterfaces) {}
	public virtual bool GetEnabled(System.Web.UI.Control control) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowsMultipleConnections { get{} }
	public Type ControlType { get{} }
	public Type InterfaceType { get{} }
	public string ID { get{} }
	public string DisplayName { get{} }
}


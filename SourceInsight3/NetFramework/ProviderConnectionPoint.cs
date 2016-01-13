public class ProviderConnectionPoint : ConnectionPoint
{

	// Constructors
	public ProviderConnectionPoint(System.Reflection.MethodInfo callbackMethod, Type interfaceType, Type controlType, string displayName, string id, bool allowsMultipleConnections) {}

	// Methods
	public virtual ConnectionInterfaceCollection GetSecondaryInterfaces(System.Web.UI.Control control) {}
	public virtual object GetObject(System.Web.UI.Control control) {}
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


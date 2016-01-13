public class ConnectionConsumerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ConnectionConsumerAttribute(string displayName) {}
	public ConnectionConsumerAttribute(string displayName, string id) {}
	public ConnectionConsumerAttribute(string displayName, Type connectionPointType) {}
	public ConnectionConsumerAttribute(string displayName, string id, Type connectionPointType) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool AllowsMultipleConnections { get{} set{} }
	public string ID { get{} }
	public string DisplayName { get{} }
	public Type ConnectionPointType { get{} }
	public object TypeId { get{} }
}


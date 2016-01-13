public class ServiceDescriptionReflector
{

	// Constructors
	public ServiceDescriptionReflector() {}

	// Methods
	public void Reflect(Type type, string url) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ServiceDescriptionCollection ServiceDescriptions { get{} }
	public System.Xml.Serialization.XmlSchemas Schemas { get{} }
}


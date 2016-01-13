public class WebPartTransformerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public WebPartTransformerAttribute(Type consumerType, Type providerType) {}

	// Methods
	public static Type GetConsumerType(Type transformerType) {}
	public static Type GetProviderType(Type transformerType) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type ConsumerType { get{} }
	public Type ProviderType { get{} }
	public object TypeId { get{} }
}


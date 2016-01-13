public class ResourceConsumptionAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ResourceConsumptionAttribute(ResourceScope resourceScope) {}
	public ResourceConsumptionAttribute(ResourceScope resourceScope, ResourceScope consumptionScope) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public ResourceScope ResourceScope { get{} }
	public ResourceScope ConsumptionScope { get{} }
	public object TypeId { get{} }
}


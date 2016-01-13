public class EventDescriptor : MemberDescriptor
{

	// Methods
	public abstract virtual void AddEventHandler(object component, System.Delegate value) {}
	public abstract virtual void RemoveEventHandler(object component, System.Delegate value) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public Type ComponentType { get{} }
	public Type EventType { get{} }
	public bool IsMulticast { get{} }
	public AttributeCollection Attributes { get{} }
	public string Category { get{} }
	public string Description { get{} }
	public bool IsBrowsable { get{} }
	public string Name { get{} }
	public bool DesignTimeOnly { get{} }
	public string DisplayName { get{} }
}


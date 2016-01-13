public class MemberDescriptor
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public AttributeCollection Attributes { get{} }
	public string Category { get{} }
	public string Description { get{} }
	public bool IsBrowsable { get{} }
	public string Name { get{} }
	public bool DesignTimeOnly { get{} }
	public string DisplayName { get{} }
}


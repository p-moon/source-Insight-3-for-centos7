public class ParseChildrenAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ParseChildrenAttribute() {}
	public ParseChildrenAttribute(bool childrenAsProperties) {}
	public ParseChildrenAttribute(Type childControlType) {}
	public ParseChildrenAttribute(bool childrenAsProperties, string defaultProperty) {}

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ParseChildrenAttribute ParseAsChildren;
	public ParseChildrenAttribute ParseAsProperties;
	public ParseChildrenAttribute Default;

	// Properties
	public Type ChildControlType { get{} }
	public bool ChildrenAsProperties { get{} set{} }
	public string DefaultProperty { get{} set{} }
	public object TypeId { get{} }
}


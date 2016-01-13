public class TemplateContainerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public TemplateContainerAttribute(Type containerType) {}
	public TemplateContainerAttribute(Type containerType, System.ComponentModel.BindingDirection bindingDirection) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.ComponentModel.BindingDirection BindingDirection { get{} }
	public Type ContainerType { get{} }
	public object TypeId { get{} }
}


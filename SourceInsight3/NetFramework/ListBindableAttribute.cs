public class ListBindableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ListBindableAttribute(bool listBindable) {}
	public ListBindableAttribute(BindableSupport flags) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public ListBindableAttribute Yes;
	public ListBindableAttribute No;
	public ListBindableAttribute Default;

	// Properties
	public bool ListBindable { get{} }
	public object TypeId { get{} }
}


public class TemplateInstanceAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public TemplateInstanceAttribute(TemplateInstance instances) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public TemplateInstanceAttribute Multiple;
	public TemplateInstanceAttribute Single;
	public TemplateInstanceAttribute Default;

	// Properties
	public TemplateInstance Instances { get{} }
	public object TypeId { get{} }
}


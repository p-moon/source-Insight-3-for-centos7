public class NonVisualControlAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public NonVisualControlAttribute() {}
	public NonVisualControlAttribute(bool nonVisual) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public NonVisualControlAttribute NonVisual;
	public NonVisualControlAttribute Visual;
	public NonVisualControlAttribute Default;

	// Properties
	public bool IsNonVisual { get{} }
	public object TypeId { get{} }
}


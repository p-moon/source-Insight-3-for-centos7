public class RefreshPropertiesAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public RefreshPropertiesAttribute(RefreshProperties refresh) {}

	// Methods
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual bool IsDefaultAttribute() {}
	public virtual bool Match(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public RefreshPropertiesAttribute All;
	public RefreshPropertiesAttribute Repaint;
	public RefreshPropertiesAttribute Default;

	// Properties
	public RefreshProperties RefreshProperties { get{} }
	public object TypeId { get{} }
}


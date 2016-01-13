public class SettingsBindableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SettingsBindableAttribute(bool bindable) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Fields
	public SettingsBindableAttribute Yes;
	public SettingsBindableAttribute No;

	// Properties
	public bool Bindable { get{} }
	public object TypeId { get{} }
}


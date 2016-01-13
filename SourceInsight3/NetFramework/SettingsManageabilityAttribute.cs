public class SettingsManageabilityAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SettingsManageabilityAttribute(SettingsManageability manageability) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public SettingsManageability Manageability { get{} }
	public object TypeId { get{} }
}


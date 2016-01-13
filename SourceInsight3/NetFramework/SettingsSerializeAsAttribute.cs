public class SettingsSerializeAsAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SettingsSerializeAsAttribute(SettingsSerializeAs serializeAs) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public SettingsSerializeAs SerializeAs { get{} }
	public object TypeId { get{} }
}


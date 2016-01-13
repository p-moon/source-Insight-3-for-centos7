public class SpecialSettingAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SpecialSettingAttribute(SpecialSetting specialSetting) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public SpecialSetting SpecialSetting { get{} }
	public object TypeId { get{} }
}


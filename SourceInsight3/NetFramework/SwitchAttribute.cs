public class SwitchAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public SwitchAttribute(string switchName, Type switchType) {}

	// Methods
	public static SwitchAttribute[] GetAll(System.Reflection.Assembly assembly) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string SwitchName { get{} set{} }
	public Type SwitchType { get{} set{} }
	public string SwitchDescription { get{} set{} }
	public object TypeId { get{} }
}


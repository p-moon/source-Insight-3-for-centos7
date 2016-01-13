public class ControlSkin
{

	// Constructors
	public ControlSkin(Type controlType, ControlSkinDelegate themeDelegate) {}

	// Methods
	public void ApplySkin(Control control) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Type ControlType { get{} }
}


public class DesignerActionList
{

	// Constructors
	public DesignerActionList(System.ComponentModel.IComponent component) {}

	// Methods
	public object GetService(Type serviceType) {}
	public virtual DesignerActionItemCollection GetSortedActionItems() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AutoShow { get{} set{} }
	public System.ComponentModel.IComponent Component { get{} }
}


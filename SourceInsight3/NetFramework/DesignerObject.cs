public class DesignerObject : System.IServiceProvider
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ControlDesigner Designer { get{} }
	public string Name { get{} }
	public System.Collections.IDictionary Properties { get{} }
}


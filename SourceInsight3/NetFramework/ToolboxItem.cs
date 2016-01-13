public class ToolboxItem : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ToolboxItem() {}
	public ToolboxItem(Type toolType) {}

	// Methods
	public System.ComponentModel.IComponent[] CreateComponents() {}
	public System.ComponentModel.IComponent[] CreateComponents(System.ComponentModel.Design.IDesignerHost host) {}
	public System.ComponentModel.IComponent[] CreateComponents(System.ComponentModel.Design.IDesignerHost host, System.Collections.IDictionary defaultValues) {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType(System.ComponentModel.Design.IDesignerHost host) {}
	public virtual void Initialize(Type type) {}
	public virtual void Lock() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public System.Reflection.AssemblyName AssemblyName { get{} set{} }
	public System.Reflection.AssemblyName[] DependentAssemblies { get{} set{} }
	public System.Drawing.Bitmap Bitmap { get{} set{} }
	public string Company { get{} set{} }
	public string ComponentType { get{} }
	public string Description { get{} set{} }
	public string DisplayName { get{} set{} }
	public System.Collections.ICollection Filter { get{} set{} }
	public bool IsTransient { get{} set{} }
	public bool Locked { get{} }
	public System.Collections.IDictionary Properties { get{} }
	public string TypeName { get{} set{} }
	public string Version { get{} }

	// Events
	public event System.Drawing.Design.ToolboxComponentsCreatedEventHandler ComponentsCreated;
	public event System.Drawing.Design.ToolboxComponentsCreatingEventHandler ComponentsCreating;
}


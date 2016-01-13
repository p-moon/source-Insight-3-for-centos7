public class ToolboxItemContainer : System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ToolboxItemContainer(ToolboxItem item) {}
	public ToolboxItemContainer(System.Windows.Forms.IDataObject data) {}

	// Methods
	public void UpdateFilter(ToolboxItem item) {}
	public virtual bool Equals(object obj) {}
	public virtual System.Collections.ICollection GetFilter(System.Collections.ICollection creators) {}
	public virtual int GetHashCode() {}
	public virtual ToolboxItem GetToolboxItem(System.Collections.ICollection creators) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool IsCreated { get{} }
	public bool IsTransient { get{} }
	public System.Windows.Forms.IDataObject ToolboxData { get{} }
}


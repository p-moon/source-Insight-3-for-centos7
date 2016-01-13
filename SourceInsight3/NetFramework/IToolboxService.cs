public interface IToolboxService
{

	// Methods
	public abstract virtual void AddCreator(ToolboxItemCreatorCallback creator, string format) {}
	public abstract virtual void AddCreator(ToolboxItemCreatorCallback creator, string format, System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual void AddLinkedToolboxItem(ToolboxItem toolboxItem, System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual void AddLinkedToolboxItem(ToolboxItem toolboxItem, string category, System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual void AddToolboxItem(ToolboxItem toolboxItem) {}
	public abstract virtual void AddToolboxItem(ToolboxItem toolboxItem, string category) {}
	public abstract virtual ToolboxItem DeserializeToolboxItem(object serializedObject) {}
	public abstract virtual ToolboxItem DeserializeToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual ToolboxItem GetSelectedToolboxItem() {}
	public abstract virtual ToolboxItem GetSelectedToolboxItem(System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual ToolboxItemCollection GetToolboxItems() {}
	public abstract virtual ToolboxItemCollection GetToolboxItems(System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual ToolboxItemCollection GetToolboxItems(string category) {}
	public abstract virtual ToolboxItemCollection GetToolboxItems(string category, System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual bool IsSupported(object serializedObject, System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual bool IsSupported(object serializedObject, System.Collections.ICollection filterAttributes) {}
	public abstract virtual bool IsToolboxItem(object serializedObject) {}
	public abstract virtual bool IsToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual void Refresh() {}
	public abstract virtual void RemoveCreator(string format) {}
	public abstract virtual void RemoveCreator(string format, System.ComponentModel.Design.IDesignerHost host) {}
	public abstract virtual void RemoveToolboxItem(ToolboxItem toolboxItem) {}
	public abstract virtual void RemoveToolboxItem(ToolboxItem toolboxItem, string category) {}
	public abstract virtual void SelectedToolboxItemUsed() {}
	public abstract virtual object SerializeToolboxItem(ToolboxItem toolboxItem) {}
	public abstract virtual bool SetCursor() {}
	public abstract virtual void SetSelectedToolboxItem(ToolboxItem toolboxItem) {}

	// Properties
	public CategoryNameCollection CategoryNames { get{} }
	public string SelectedCategory { get{} set{} }
}


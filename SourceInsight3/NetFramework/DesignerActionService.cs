public class DesignerActionService : System.IDisposable
{

	// Constructors
	public DesignerActionService(System.IServiceProvider serviceProvider) {}

	// Methods
	public void Add(System.ComponentModel.IComponent comp, DesignerActionListCollection designerActionListCollection) {}
	public void Add(System.ComponentModel.IComponent comp, DesignerActionList actionList) {}
	public void Clear() {}
	public bool Contains(System.ComponentModel.IComponent comp) {}
	public virtual void Dispose() {}
	public DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component) {}
	public virtual DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component, ComponentActionsType type) {}
	public void Remove(System.ComponentModel.IComponent comp) {}
	public void Remove(DesignerActionList actionList) {}
	public void Remove(System.ComponentModel.IComponent comp, DesignerActionList actionList) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.ComponentModel.Design.DesignerActionListsChangedEventHandler DesignerActionListsChanged;
}


public class WebFormsDesignerActionService : System.ComponentModel.Design.DesignerActionService, System.IDisposable
{

	// Constructors
	public WebFormsDesignerActionService(System.IServiceProvider serviceProvider) {}

	// Methods
	public void Add(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionListCollection designerActionListCollection) {}
	public void Add(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionList actionList) {}
	public void Clear() {}
	public bool Contains(System.ComponentModel.IComponent comp) {}
	public virtual void Dispose() {}
	public System.ComponentModel.Design.DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component) {}
	public virtual System.ComponentModel.Design.DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.ComponentActionsType type) {}
	public void Remove(System.ComponentModel.IComponent comp) {}
	public void Remove(System.ComponentModel.Design.DesignerActionList actionList) {}
	public void Remove(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionList actionList) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.ComponentModel.Design.DesignerActionListsChangedEventHandler DesignerActionListsChanged;
}


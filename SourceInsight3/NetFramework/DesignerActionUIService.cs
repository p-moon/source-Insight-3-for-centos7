public class DesignerActionUIService : System.IDisposable
{

	// Methods
	public virtual void Dispose() {}
	public void HideUI(System.ComponentModel.IComponent component) {}
	public void ShowUI(System.ComponentModel.IComponent component) {}
	public void Refresh(System.ComponentModel.IComponent component) {}
	public bool ShouldAutoShow(System.ComponentModel.IComponent component) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.ComponentModel.Design.DesignerActionUIStateChangeEventHandler DesignerActionUIStateChange;
}


public interface IComponentDesignerStateService
{

	// Methods
	public abstract virtual object GetState(System.ComponentModel.IComponent component, string key) {}
	public abstract virtual void SetState(System.ComponentModel.IComponent component, string key, object value) {}
}


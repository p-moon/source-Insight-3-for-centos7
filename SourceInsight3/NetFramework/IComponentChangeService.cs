public interface IComponentChangeService
{

	// Methods
	public abstract virtual void OnComponentChanged(object component, System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) {}
	public abstract virtual void OnComponentChanging(object component, System.ComponentModel.MemberDescriptor member) {}

	// Events
	public event System.ComponentModel.Design.ComponentEventHandler ComponentAdded;
	public event System.ComponentModel.Design.ComponentEventHandler ComponentAdding;
	public event System.ComponentModel.Design.ComponentChangedEventHandler ComponentChanged;
	public event System.ComponentModel.Design.ComponentChangingEventHandler ComponentChanging;
	public event System.ComponentModel.Design.ComponentEventHandler ComponentRemoved;
	public event System.ComponentModel.Design.ComponentEventHandler ComponentRemoving;
	public event System.ComponentModel.Design.ComponentRenameEventHandler ComponentRename;
}


public interface IComPropertyBrowser
{

	// Methods
	public abstract virtual void DropDownDone() {}
	public abstract virtual bool EnsurePendingChangesCommitted() {}
	public abstract virtual void HandleF4() {}
	public abstract virtual void LoadState(Microsoft.Win32.RegistryKey key) {}
	public abstract virtual void SaveState(Microsoft.Win32.RegistryKey key) {}

	// Properties
	public bool InPropertySet { get{} }

	// Events
	public event System.ComponentModel.Design.ComponentRenameEventHandler ComComponentNameChanged;
}


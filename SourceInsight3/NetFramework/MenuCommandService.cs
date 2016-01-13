public class MenuCommandService : IMenuCommandService, System.IDisposable
{

	// Constructors
	public MenuCommandService(System.IServiceProvider serviceProvider) {}

	// Methods
	public virtual void AddCommand(MenuCommand command) {}
	public virtual void AddVerb(DesignerVerb verb) {}
	public virtual void Dispose() {}
	public virtual MenuCommand FindCommand(CommandID commandID) {}
	public virtual bool GlobalInvoke(CommandID commandID) {}
	public virtual bool GlobalInvoke(CommandID commandId, object arg) {}
	public virtual void RemoveCommand(MenuCommand command) {}
	public virtual void RemoveVerb(DesignerVerb verb) {}
	public virtual void ShowContextMenu(CommandID menuID, int x, int y) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DesignerVerbCollection Verbs { get{} }

	// Events
	public event System.ComponentModel.Design.MenuCommandsChangedEventHandler MenuCommandsChanged;
}


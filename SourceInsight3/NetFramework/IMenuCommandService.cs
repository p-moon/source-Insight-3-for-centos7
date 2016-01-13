public interface IMenuCommandService
{

	// Methods
	public abstract virtual void AddCommand(MenuCommand command) {}
	public abstract virtual void AddVerb(DesignerVerb verb) {}
	public abstract virtual MenuCommand FindCommand(CommandID commandID) {}
	public abstract virtual bool GlobalInvoke(CommandID commandID) {}
	public abstract virtual void RemoveCommand(MenuCommand command) {}
	public abstract virtual void RemoveVerb(DesignerVerb verb) {}
	public abstract virtual void ShowContextMenu(CommandID menuID, int x, int y) {}

	// Properties
	public DesignerVerbCollection Verbs { get{} }
}


public class MenuCommandsChangedEventArgs : System.EventArgs
{

	// Constructors
	public MenuCommandsChangedEventArgs(MenuCommandsChangedType changeType, MenuCommand command) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MenuCommandsChangedType ChangeType { get{} }
	public MenuCommand Command { get{} }
}


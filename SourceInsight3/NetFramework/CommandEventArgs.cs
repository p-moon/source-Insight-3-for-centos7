public class CommandEventArgs : System.EventArgs
{

	// Constructors
	public CommandEventArgs(CommandEventArgs e) {}
	public CommandEventArgs(string commandName, object argument) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CommandName { get{} }
	public object CommandArgument { get{} }
}


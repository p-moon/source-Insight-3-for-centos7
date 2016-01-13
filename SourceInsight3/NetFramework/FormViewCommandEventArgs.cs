public class FormViewCommandEventArgs : CommandEventArgs
{

	// Constructors
	public FormViewCommandEventArgs(object commandSource, CommandEventArgs originalArgs) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object CommandSource { get{} }
	public string CommandName { get{} }
	public object CommandArgument { get{} }
}


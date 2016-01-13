public class MenuEventArgs : CommandEventArgs
{

	// Constructors
	public MenuEventArgs(MenuItem item, object commandSource, CommandEventArgs originalArgs) {}
	public MenuEventArgs(MenuItem item) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object CommandSource { get{} }
	public MenuItem Item { get{} }
	public string CommandName { get{} }
	public object CommandArgument { get{} }
}


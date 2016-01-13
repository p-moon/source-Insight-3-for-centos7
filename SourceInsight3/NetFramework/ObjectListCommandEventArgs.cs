public class ObjectListCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs
{

	// Constructors
	public ObjectListCommandEventArgs(ObjectListItem item, object commandSource, System.Web.UI.WebControls.CommandEventArgs originalArgs) {}
	public ObjectListCommandEventArgs(ObjectListItem item, string commandName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public ObjectListItem ListItem { get{} }
	public object CommandSource { get{} }
	public string CommandName { get{} }
	public object CommandArgument { get{} }
}


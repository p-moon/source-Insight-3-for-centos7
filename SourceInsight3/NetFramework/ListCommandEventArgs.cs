public class ListCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs
{

	// Constructors
	public ListCommandEventArgs(MobileListItem item, object commandSource, System.Web.UI.WebControls.CommandEventArgs originalArgs) {}
	public ListCommandEventArgs(MobileListItem item, object commandSource) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MobileListItem ListItem { get{} }
	public object CommandSource { get{} }
	public string CommandName { get{} }
	public object CommandArgument { get{} }
}


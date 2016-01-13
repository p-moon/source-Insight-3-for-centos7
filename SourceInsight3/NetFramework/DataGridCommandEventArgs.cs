public class DataGridCommandEventArgs : CommandEventArgs
{

	// Constructors
	public DataGridCommandEventArgs(DataGridItem item, object commandSource, CommandEventArgs originalArgs) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object CommandSource { get{} }
	public DataGridItem Item { get{} }
	public string CommandName { get{} }
	public object CommandArgument { get{} }
}


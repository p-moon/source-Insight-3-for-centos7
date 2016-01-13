public class ObjectDataSourceSelectingEventArgs : ObjectDataSourceMethodEventArgs
{

	// Constructors
	public ObjectDataSourceSelectingEventArgs(System.Collections.Specialized.IOrderedDictionary inputParameters, System.Web.UI.DataSourceSelectArguments arguments, bool executingSelectCount) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Web.UI.DataSourceSelectArguments Arguments { get{} }
	public bool ExecutingSelectCount { get{} }
	public System.Collections.Specialized.IOrderedDictionary InputParameters { get{} }
	public bool Cancel { get{} set{} }
}


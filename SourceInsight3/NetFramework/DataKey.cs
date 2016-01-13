public class DataKey : System.Web.UI.IStateManager
{

	// Constructors
	public DataKey(System.Collections.Specialized.IOrderedDictionary keyTable) {}
	public DataKey(System.Collections.Specialized.IOrderedDictionary keyTable, string[] keyNames) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Item { get{} }
	public object Item { get{} }
	public object Value { get{} }
	public System.Collections.Specialized.IOrderedDictionary Values { get{} }
}


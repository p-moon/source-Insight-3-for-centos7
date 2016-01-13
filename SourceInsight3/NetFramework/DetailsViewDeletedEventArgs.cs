public class DetailsViewDeletedEventArgs : System.EventArgs
{

	// Constructors
	public DetailsViewDeletedEventArgs(int affectedRows, System.Exception e) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int AffectedRows { get{} }
	public System.Exception Exception { get{} }
	public bool ExceptionHandled { get{} set{} }
	public System.Collections.Specialized.IOrderedDictionary Keys { get{} }
	public System.Collections.Specialized.IOrderedDictionary Values { get{} }
}


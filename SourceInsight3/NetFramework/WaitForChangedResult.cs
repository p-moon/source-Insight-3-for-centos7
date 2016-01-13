public class WaitForChangedResult : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public WatcherChangeTypes ChangeType { get{} set{} }
	public string Name { get{} set{} }
	public string OldName { get{} set{} }
	public bool TimedOut { get{} set{} }
}


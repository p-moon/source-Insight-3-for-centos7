public class CacheVirtualItemsEventArgs : System.EventArgs
{

	// Constructors
	public CacheVirtualItemsEventArgs(int startIndex, int endIndex) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int StartIndex { get{} }
	public int EndIndex { get{} }
}


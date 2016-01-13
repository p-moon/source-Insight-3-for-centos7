public class LoadItemsEventArgs : System.EventArgs
{

	// Constructors
	public LoadItemsEventArgs(int index, int count) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ItemIndex { get{} }
	public int ItemCount { get{} }
}


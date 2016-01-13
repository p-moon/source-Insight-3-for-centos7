public class PeekCompletedEventArgs : System.EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.IAsyncResult AsyncResult { get{} set{} }
	public Message Message { get{} }
}


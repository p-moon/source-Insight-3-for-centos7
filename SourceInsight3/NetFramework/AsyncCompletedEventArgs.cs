public class AsyncCompletedEventArgs : System.EventArgs
{

	// Constructors
	public AsyncCompletedEventArgs(System.Exception error, bool cancelled, object userState) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Cancelled { get{} }
	public System.Exception Error { get{} }
	public object UserState { get{} }
}


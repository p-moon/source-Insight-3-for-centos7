public class DownloadFileGroupCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Group { get{} }
	public bool Cancelled { get{} }
	public System.Exception Error { get{} }
	public object UserState { get{} }
}


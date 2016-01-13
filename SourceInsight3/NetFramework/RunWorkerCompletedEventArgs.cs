public class RunWorkerCompletedEventArgs : AsyncCompletedEventArgs
{

	// Constructors
	public RunWorkerCompletedEventArgs(object result, System.Exception error, bool cancelled) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Result { get{} }
	public object UserState { get{} }
	public bool Cancelled { get{} }
	public System.Exception Error { get{} }
}


public class WebClientAsyncResult : System.IAsyncResult
{

	// Methods
	public void Abort() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object AsyncState { get{} }
	public System.Threading.WaitHandle AsyncWaitHandle { get{} }
	public bool CompletedSynchronously { get{} }
	public bool IsCompleted { get{} }
}


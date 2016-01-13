public interface IAsyncResult
{

	// Properties
	public bool IsCompleted { get{} }
	public System.Threading.WaitHandle AsyncWaitHandle { get{} }
	public object AsyncState { get{} }
	public bool CompletedSynchronously { get{} }
}


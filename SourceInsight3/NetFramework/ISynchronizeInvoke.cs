public interface ISynchronizeInvoke
{

	// Methods
	public abstract virtual System.IAsyncResult BeginInvoke(System.Delegate method, object[] args) {}
	public abstract virtual object EndInvoke(System.IAsyncResult result) {}
	public abstract virtual object Invoke(System.Delegate method, object[] args) {}

	// Properties
	public bool InvokeRequired { get{} }
}


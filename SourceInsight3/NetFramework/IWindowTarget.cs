public interface IWindowTarget
{

	// Methods
	public abstract virtual void OnHandleChange(System.IntPtr newHandle) {}
	public abstract virtual void OnMessage(Message& m) {}
}


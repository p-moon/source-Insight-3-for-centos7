public interface IServerChannelSinkStack : IServerResponseChannelSinkStack
{

	// Methods
	public abstract virtual void Push(IServerChannelSink sink, object state) {}
	public abstract virtual object Pop(IServerChannelSink sink) {}
	public abstract virtual void Store(IServerChannelSink sink, object state) {}
	public abstract virtual void StoreAndDispatch(IServerChannelSink sink, object state) {}
	public abstract virtual void ServerCallback(System.IAsyncResult ar) {}
}


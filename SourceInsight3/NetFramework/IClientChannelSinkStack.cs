public interface IClientChannelSinkStack : IClientResponseChannelSinkStack
{

	// Methods
	public abstract virtual void Push(IClientChannelSink sink, object state) {}
	public abstract virtual object Pop(IClientChannelSink sink) {}
}


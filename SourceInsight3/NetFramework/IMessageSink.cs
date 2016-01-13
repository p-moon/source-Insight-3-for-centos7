public interface IMessageSink
{

	// Methods
	public abstract virtual IMessage SyncProcessMessage(IMessage msg) {}
	public abstract virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) {}

	// Properties
	public IMessageSink NextSink { get{} }
}


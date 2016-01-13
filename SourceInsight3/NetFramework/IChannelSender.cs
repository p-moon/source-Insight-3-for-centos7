public interface IChannelSender : IChannel
{

	// Methods
	public abstract virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelDataout , System.String& objectURI) {}
}


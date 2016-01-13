public interface IChannelReceiver : IChannel
{

	// Methods
	public abstract virtual string[] GetUrlsForUri(string objectURI) {}
	public abstract virtual void StartListening(object data) {}
	public abstract virtual void StopListening(object data) {}

	// Properties
	public object ChannelData { get{} }
}


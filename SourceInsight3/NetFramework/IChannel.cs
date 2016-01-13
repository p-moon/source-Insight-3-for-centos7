public interface IChannel
{

	// Methods
	public abstract virtual string Parse(string urlout , System.String& objectURI) {}

	// Properties
	public int ChannelPriority { get{} }
	public string ChannelName { get{} }
}


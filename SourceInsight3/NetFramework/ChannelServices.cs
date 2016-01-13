public class ChannelServices
{

	// Methods
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) {}
	public static void RegisterChannel(IChannel chnl) {}
	public static void UnregisterChannel(IChannel chnl) {}
	public static IChannel GetChannel(string name) {}
	public static string[] GetUrlsForObject(System.MarshalByRefObject obj) {}
	public static System.Collections.IDictionary GetChannelSinkProperties(object obj) {}
	public static ServerProcessing DispatchMessage(IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msgout , System.Runtime.Remoting.Messaging.IMessage& replyMsg) {}
	public static System.Runtime.Remoting.Messaging.IMessage SyncDispatchMessage(System.Runtime.Remoting.Messaging.IMessage msg) {}
	public static System.Runtime.Remoting.Messaging.IMessageCtrl AsyncDispatchMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) {}
	public static IServerChannelSink CreateServerChannelSinkChain(IServerChannelSinkProvider provider, IChannelReceiver channel) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IChannel[] RegisteredChannels { get{} }
}


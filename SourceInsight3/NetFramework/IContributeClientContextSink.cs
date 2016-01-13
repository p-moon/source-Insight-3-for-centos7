public interface IContributeClientContextSink
{

	// Methods
	public abstract virtual System.Runtime.Remoting.Messaging.IMessageSink GetClientContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink) {}
}


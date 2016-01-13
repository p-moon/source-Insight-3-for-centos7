public interface IContributeServerContextSink
{

	// Methods
	public abstract virtual System.Runtime.Remoting.Messaging.IMessageSink GetServerContextSink(System.Runtime.Remoting.Messaging.IMessageSink nextSink) {}
}


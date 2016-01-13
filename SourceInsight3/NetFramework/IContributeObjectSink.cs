public interface IContributeObjectSink
{

	// Methods
	public abstract virtual System.Runtime.Remoting.Messaging.IMessageSink GetObjectSink(System.MarshalByRefObject obj, System.Runtime.Remoting.Messaging.IMessageSink nextSink) {}
}


public interface IContributeEnvoySink
{

	// Methods
	public abstract virtual System.Runtime.Remoting.Messaging.IMessageSink GetEnvoySink(System.MarshalByRefObject obj, System.Runtime.Remoting.Messaging.IMessageSink nextSink) {}
}


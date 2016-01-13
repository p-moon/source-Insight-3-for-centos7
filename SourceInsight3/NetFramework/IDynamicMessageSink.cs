public interface IDynamicMessageSink
{

	// Methods
	public abstract virtual void ProcessMessageStart(System.Runtime.Remoting.Messaging.IMessage reqMsg, bool bCliSide, bool bAsync) {}
	public abstract virtual void ProcessMessageFinish(System.Runtime.Remoting.Messaging.IMessage replyMsg, bool bCliSide, bool bAsync) {}
}


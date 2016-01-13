public interface ICallbackEventHandler
{

	// Methods
	public abstract virtual void RaiseCallbackEvent(string eventArgument) {}
	public abstract virtual string GetCallbackResult() {}
}


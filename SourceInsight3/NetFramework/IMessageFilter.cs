public interface IMessageFilter
{

	// Methods
	public abstract virtual bool PreFilterMessage(Message& m) {}
}


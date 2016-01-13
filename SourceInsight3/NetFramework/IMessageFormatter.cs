public interface IMessageFormatter : System.ICloneable
{

	// Methods
	public abstract virtual bool CanRead(Message message) {}
	public abstract virtual object Read(Message message) {}
	public abstract virtual void Write(Message message, object obj) {}
}


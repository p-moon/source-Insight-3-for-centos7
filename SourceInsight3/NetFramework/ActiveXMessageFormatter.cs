public class ActiveXMessageFormatter : IMessageFormatter, System.ICloneable
{

	// Constructors
	public ActiveXMessageFormatter() {}

	// Methods
	public virtual bool CanRead(Message message) {}
	public virtual object Clone() {}
	public static void InitStreamedObject(object streamedObject) {}
	public virtual object Read(Message message) {}
	public virtual void Write(Message message, object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


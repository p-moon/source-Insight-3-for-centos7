public class BaseEvent : IEvent
{

	// Methods
	public virtual void Fire() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


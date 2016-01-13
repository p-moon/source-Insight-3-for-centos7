public class HostExecutionContextManager
{

	// Constructors
	public HostExecutionContextManager() {}

	// Methods
	public virtual HostExecutionContext Capture() {}
	public virtual object SetHostExecutionContext(HostExecutionContext hostExecutionContext) {}
	public virtual void Revert(object previousState) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
}


public interface IProcessHostIdleAndHealthCheck
{

	// Methods
	public abstract virtual bool IsIdle() {}
	public abstract virtual void Ping(IProcessPingCallback callback) {}
}


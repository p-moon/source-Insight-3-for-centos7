public interface IISAPIRuntime
{

	// Methods
	public abstract virtual void StartProcessing() {}
	public abstract virtual void StopProcessing() {}
	public abstract virtual int ProcessRequest(System.IntPtr ecb, int useProcessModel) {}
	public abstract virtual void DoGCCollect() {}
}


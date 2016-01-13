public interface IOleServiceProvider
{

	// Methods
	public abstract virtual int QueryService(System.Guid& guidService, System.Guid& riidout , System.IntPtr& ppvObject) {}
}


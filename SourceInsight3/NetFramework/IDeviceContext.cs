public interface IDeviceContext : System.IDisposable
{

	// Methods
	public abstract virtual System.IntPtr GetHdc() {}
	public abstract virtual void ReleaseHdc() {}
}


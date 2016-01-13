public interface IHttpModule
{

	// Methods
	public abstract virtual void Init(HttpApplication context) {}
	public abstract virtual void Dispose() {}
}


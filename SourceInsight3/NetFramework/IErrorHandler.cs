public interface IErrorHandler
{

	// Methods
	public abstract virtual bool OnCompilerError(IVsaFullErrorInfo error) {}
}


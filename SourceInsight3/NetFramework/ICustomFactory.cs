public interface ICustomFactory
{

	// Methods
	public abstract virtual System.MarshalByRefObject CreateInstance(Type serverType) {}
}


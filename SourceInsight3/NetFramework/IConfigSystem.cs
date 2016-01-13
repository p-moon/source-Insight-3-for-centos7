public interface IConfigSystem
{

	// Methods
	public abstract virtual void Init(Type typeConfigHost, object[] hostInitParams) {}

	// Properties
	public IInternalConfigHost Host { get{} }
	public IInternalConfigRoot Root { get{} }
}


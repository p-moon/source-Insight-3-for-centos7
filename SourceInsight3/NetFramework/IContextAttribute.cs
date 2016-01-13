public interface IContextAttribute
{

	// Methods
	public abstract virtual bool IsContextOK(Context ctx, System.Runtime.Remoting.Activation.IConstructionCallMessage msg) {}
	public abstract virtual void GetPropertiesForNewContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg) {}
}


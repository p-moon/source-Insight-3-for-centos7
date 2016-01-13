public interface IContextPropertyActivator
{

	// Methods
	public abstract virtual bool IsOKToActivate(System.Runtime.Remoting.Activation.IConstructionCallMessage msg) {}
	public abstract virtual void CollectFromClientContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg) {}
	public abstract virtual bool DeliverClientContextToServerContext(System.Runtime.Remoting.Activation.IConstructionCallMessage msg) {}
	public abstract virtual void CollectFromServerContext(System.Runtime.Remoting.Activation.IConstructionReturnMessage msg) {}
	public abstract virtual bool DeliverServerContextToClientContext(System.Runtime.Remoting.Activation.IConstructionReturnMessage msg) {}
}


public interface IConstructionCallMessage : System.Runtime.Remoting.Messaging.IMethodCallMessage, System.Runtime.Remoting.Messaging.IMethodMessage, System.Runtime.Remoting.Messaging.IMessage
{

	// Properties
	public IActivator Activator { get{} set{} }
	public object[] CallSiteActivationAttributes { get{} }
	public string ActivationTypeName { get{} }
	public Type ActivationType { get{} }
	public System.Collections.IList ContextProperties { get{} }
}


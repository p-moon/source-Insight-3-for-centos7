public class ConstructionCall : MethodCall, IMethodCallMessage, IMethodMessage, IMessage, System.Runtime.Serialization.ISerializable, IInternalMessage, ISerializationRootObject, System.Runtime.Remoting.Activation.IConstructionCallMessage
{

	// Constructors
	public ConstructionCall(Header[] headers) {}
	public ConstructionCall(IMessage m) {}

	// Methods
	public virtual void RootSetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) {}
	public void ResolveMethod() {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual void Init() {}
	public virtual object GetArg(int argNum) {}
	public virtual string GetArgName(int index) {}
	public virtual object GetInArg(int argNum) {}
	public virtual string GetInArgName(int index) {}
	public virtual object HeaderHandler(Header[] h) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object[] CallSiteActivationAttributes { get{} }
	public Type ActivationType { get{} }
	public string ActivationTypeName { get{} }
	public System.Collections.IList ContextProperties { get{} }
	public System.Collections.IDictionary Properties { get{} }
	public System.Runtime.Remoting.Activation.IActivator Activator { get{} set{} }
	public int ArgCount { get{} }
	public object[] Args { get{} }
	public int InArgCount { get{} }
	public object[] InArgs { get{} }
	public string MethodName { get{} }
	public string TypeName { get{} }
	public object MethodSignature { get{} }
	public System.Reflection.MethodBase MethodBase { get{} }
	public string Uri { get{} set{} }
	public bool HasVarArgs { get{} }
	public LogicalCallContext LogicalCallContext { get{} }
}


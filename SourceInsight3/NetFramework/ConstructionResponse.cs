public class ConstructionResponse : MethodResponse, IMethodReturnMessage, IMethodMessage, IMessage, System.Runtime.Serialization.ISerializable, ISerializationRootObject, IInternalMessage, System.Runtime.Remoting.Activation.IConstructionReturnMessage
{

	// Constructors
	public ConstructionResponse(Header[] h, IMethodCallMessage mcm) {}

	// Methods
	public virtual object HeaderHandler(Header[] h) {}
	public virtual void RootSetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual object GetArg(int argNum) {}
	public virtual string GetArgName(int index) {}
	public virtual object GetOutArg(int argNum) {}
	public virtual string GetOutArgName(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Collections.IDictionary Properties { get{} }
	public string Uri { get{} set{} }
	public string MethodName { get{} }
	public string TypeName { get{} }
	public object MethodSignature { get{} }
	public System.Reflection.MethodBase MethodBase { get{} }
	public bool HasVarArgs { get{} }
	public int ArgCount { get{} }
	public object[] Args { get{} }
	public int OutArgCount { get{} }
	public object[] OutArgs { get{} }
	public System.Exception Exception { get{} }
	public object ReturnValue { get{} }
	public LogicalCallContext LogicalCallContext { get{} }
}


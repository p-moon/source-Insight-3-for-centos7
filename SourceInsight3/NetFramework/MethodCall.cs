public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, System.Runtime.Serialization.ISerializable, IInternalMessage, ISerializationRootObject
{

	// Constructors
	public MethodCall(Header[] h1) {}
	public MethodCall(IMessage msg) {}

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
	public System.Collections.IDictionary Properties { get{} }
	public LogicalCallContext LogicalCallContext { get{} }
}


public class MethodCallMessageWrapper : InternalMessageWrapper, IMethodCallMessage, IMethodMessage, IMessage
{

	// Constructors
	public MethodCallMessageWrapper(IMethodCallMessage msg) {}

	// Methods
	public virtual string GetArgName(int index) {}
	public virtual object GetArg(int argNum) {}
	public virtual object GetInArg(int argNum) {}
	public virtual string GetInArgName(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Uri { get{} set{} }
	public string MethodName { get{} }
	public string TypeName { get{} }
	public object MethodSignature { get{} }
	public LogicalCallContext LogicalCallContext { get{} }
	public System.Reflection.MethodBase MethodBase { get{} }
	public int ArgCount { get{} }
	public object[] Args { get{} set{} }
	public bool HasVarArgs { get{} }
	public int InArgCount { get{} }
	public object[] InArgs { get{} }
	public System.Collections.IDictionary Properties { get{} }
}


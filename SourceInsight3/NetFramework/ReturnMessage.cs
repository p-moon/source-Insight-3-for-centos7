public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage
{

	// Constructors
	public ReturnMessage(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) {}
	public ReturnMessage(System.Exception e, IMethodCallMessage mcm) {}

	// Methods
	public virtual object GetArg(int argNum) {}
	public virtual string GetArgName(int index) {}
	public virtual object GetOutArg(int argNum) {}
	public virtual string GetOutArgName(int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
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
	public System.Collections.IDictionary Properties { get{} }
	public LogicalCallContext LogicalCallContext { get{} }
}


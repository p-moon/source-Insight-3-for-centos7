public class MethodReturnMessageWrapper : InternalMessageWrapper, IMethodReturnMessage, IMethodMessage, IMessage
{

	// Constructors
	public MethodReturnMessageWrapper(IMethodReturnMessage msg) {}

	// Methods
	public virtual string GetArgName(int index) {}
	public virtual object GetArg(int argNum) {}
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
	public LogicalCallContext LogicalCallContext { get{} }
	public System.Reflection.MethodBase MethodBase { get{} }
	public int ArgCount { get{} }
	public object[] Args { get{} set{} }
	public bool HasVarArgs { get{} }
	public int OutArgCount { get{} }
	public object[] OutArgs { get{} }
	public System.Exception Exception { get{} set{} }
	public object ReturnValue { get{} set{} }
	public System.Collections.IDictionary Properties { get{} }
}


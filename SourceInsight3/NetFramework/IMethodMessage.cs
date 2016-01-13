public interface IMethodMessage : IMessage
{

	// Methods
	public abstract virtual string GetArgName(int index) {}
	public abstract virtual object GetArg(int argNum) {}

	// Properties
	public string Uri { get{} }
	public string MethodName { get{} }
	public string TypeName { get{} }
	public object MethodSignature { get{} }
	public int ArgCount { get{} }
	public object[] Args { get{} }
	public bool HasVarArgs { get{} }
	public LogicalCallContext LogicalCallContext { get{} }
	public System.Reflection.MethodBase MethodBase { get{} }
}


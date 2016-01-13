public interface IMethodReturnMessage : IMethodMessage, IMessage
{

	// Methods
	public abstract virtual string GetOutArgName(int index) {}
	public abstract virtual object GetOutArg(int argNum) {}

	// Properties
	public int OutArgCount { get{} }
	public object[] OutArgs { get{} }
	public System.Exception Exception { get{} }
	public object ReturnValue { get{} }
}


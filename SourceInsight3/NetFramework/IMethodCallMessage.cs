public interface IMethodCallMessage : IMethodMessage, IMessage
{

	// Methods
	public abstract virtual string GetInArgName(int index) {}
	public abstract virtual object GetInArg(int argNum) {}

	// Properties
	public int InArgCount { get{} }
	public object[] InArgs { get{} }
}


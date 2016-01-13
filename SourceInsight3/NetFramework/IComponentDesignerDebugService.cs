public interface IComponentDesignerDebugService
{

	// Methods
	public abstract virtual void Assert(bool condition, string message) {}
	public abstract virtual void Fail(string message) {}
	public abstract virtual void Trace(string message, string category) {}

	// Properties
	public int IndentLevel { get{} set{} }
	public System.Diagnostics.TraceListenerCollection Listeners { get{} }
}


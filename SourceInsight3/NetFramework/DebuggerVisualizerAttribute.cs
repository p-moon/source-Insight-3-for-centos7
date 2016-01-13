public class DebuggerVisualizerAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DebuggerVisualizerAttribute(string visualizerTypeName) {}
	public DebuggerVisualizerAttribute(string visualizerTypeName, string visualizerObjectSourceTypeName) {}
	public DebuggerVisualizerAttribute(string visualizerTypeName, Type visualizerObjectSource) {}
	public DebuggerVisualizerAttribute(Type visualizer) {}
	public DebuggerVisualizerAttribute(Type visualizer, Type visualizerObjectSource) {}
	public DebuggerVisualizerAttribute(Type visualizer, string visualizerObjectSourceTypeName) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string VisualizerObjectSourceTypeName { get{} }
	public string VisualizerTypeName { get{} }
	public string Description { get{} set{} }
	public Type Target { get{} set{} }
	public string TargetTypeName { get{} set{} }
	public object TypeId { get{} }
}


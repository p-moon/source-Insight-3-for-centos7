public class DebuggableAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public DebuggableAttribute(DebuggingModes modes) {}
	public DebuggableAttribute(bool isJITTrackingEnabled, bool isJITOptimizerDisabled) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public bool IsJITTrackingEnabled { get{} }
	public bool IsJITOptimizerDisabled { get{} }
	public DebuggingModes DebuggingFlags { get{} }
	public object TypeId { get{} }
}


public class StreamingContext : System.ValueType
{

	// Constructors
	public StreamingContext(StreamingContextStates state) {}
	public StreamingContext(StreamingContextStates state, object additional) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Properties
	public object Context { get{} }
	public StreamingContextStates State { get{} }
}


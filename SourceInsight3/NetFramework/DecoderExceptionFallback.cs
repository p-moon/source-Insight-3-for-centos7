public class DecoderExceptionFallback : DecoderFallback
{

	// Constructors
	public DecoderExceptionFallback() {}

	// Methods
	public virtual DecoderFallbackBuffer CreateFallbackBuffer() {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int MaxCharCount { get{} }
}


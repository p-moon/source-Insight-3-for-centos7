public class EncoderExceptionFallback : EncoderFallback
{

	// Constructors
	public EncoderExceptionFallback() {}

	// Methods
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public int MaxCharCount { get{} }
}


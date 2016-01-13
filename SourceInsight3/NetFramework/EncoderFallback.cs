public class EncoderFallback
{

	// Methods
	public abstract virtual EncoderFallbackBuffer CreateFallbackBuffer() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EncoderFallback ReplacementFallback { get{} }
	public EncoderFallback ExceptionFallback { get{} }
	public int MaxCharCount { get{} }
}


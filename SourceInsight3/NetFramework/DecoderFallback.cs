public class DecoderFallback
{

	// Methods
	public abstract virtual DecoderFallbackBuffer CreateFallbackBuffer() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DecoderFallback ReplacementFallback { get{} }
	public DecoderFallback ExceptionFallback { get{} }
	public int MaxCharCount { get{} }
}


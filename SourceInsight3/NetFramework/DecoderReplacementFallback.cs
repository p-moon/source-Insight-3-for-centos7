public class DecoderReplacementFallback : DecoderFallback
{

	// Constructors
	public DecoderReplacementFallback() {}
	public DecoderReplacementFallback(string replacement) {}

	// Methods
	public virtual DecoderFallbackBuffer CreateFallbackBuffer() {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string DefaultString { get{} }
	public int MaxCharCount { get{} }
}


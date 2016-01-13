public class EncoderReplacementFallback : EncoderFallback
{

	// Constructors
	public EncoderReplacementFallback() {}
	public EncoderReplacementFallback(string replacement) {}

	// Methods
	public virtual EncoderFallbackBuffer CreateFallbackBuffer() {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string DefaultString { get{} }
	public int MaxCharCount { get{} }
}


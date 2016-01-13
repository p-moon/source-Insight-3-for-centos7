public class DecoderReplacementFallbackBuffer : DecoderFallbackBuffer
{

	// Constructors
	public DecoderReplacementFallbackBuffer(DecoderReplacementFallback fallback) {}

	// Methods
	public virtual bool Fallback(byte[] bytesUnknown, int index) {}
	public virtual char GetNextChar() {}
	public virtual bool MovePrevious() {}
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Remaining { get{} }
}


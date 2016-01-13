public class EncoderExceptionFallbackBuffer : EncoderFallbackBuffer
{

	// Constructors
	public EncoderExceptionFallbackBuffer() {}

	// Methods
	public virtual bool Fallback(char charUnknown, int index) {}
	public virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) {}
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


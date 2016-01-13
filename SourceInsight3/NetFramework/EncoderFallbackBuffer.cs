public class EncoderFallbackBuffer
{

	// Methods
	public abstract virtual bool Fallback(char charUnknown, int index) {}
	public abstract virtual bool Fallback(char charUnknownHigh, char charUnknownLow, int index) {}
	public abstract virtual char GetNextChar() {}
	public abstract virtual bool MovePrevious() {}
	public virtual void Reset() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int Remaining { get{} }
}


public class DecoderFallbackBuffer
{

	// Methods
	public abstract virtual bool Fallback(byte[] bytesUnknown, int index) {}
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


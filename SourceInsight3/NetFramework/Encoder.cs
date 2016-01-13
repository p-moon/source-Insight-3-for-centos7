public class Encoder
{

	// Methods
	public virtual void Reset() {}
	public abstract virtual int GetByteCount(char[] chars, int index, int count, bool flush) {}
	public virtual int GetByteCount(System.Char* chars, int count, bool flush) {}
	public abstract virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) {}
	public virtual int GetBytes(System.Char* chars, int charCount, System.Byte* bytes, int byteCount, bool flush) {}
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flushout , System.Int32& charsUsedout , System.Int32& bytesUsedout , System.Boolean& completed) {}
	public virtual void Convert(System.Char* chars, int charCount, System.Byte* bytes, int byteCount, bool flushout , System.Int32& charsUsedout , System.Int32& bytesUsedout , System.Boolean& completed) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public EncoderFallback Fallback { get{} set{} }
	public EncoderFallbackBuffer FallbackBuffer { get{} }
}


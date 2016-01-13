public class Decoder
{

	// Methods
	public virtual void Reset() {}
	public abstract virtual int GetCharCount(byte[] bytes, int index, int count) {}
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) {}
	public virtual int GetCharCount(System.Byte* bytes, int count, bool flush) {}
	public abstract virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) {}
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) {}
	public virtual int GetChars(System.Byte* bytes, int byteCount, System.Char* chars, int charCount, bool flush) {}
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flushout , System.Int32& bytesUsedout , System.Int32& charsUsedout , System.Boolean& completed) {}
	public virtual void Convert(System.Byte* bytes, int byteCount, System.Char* chars, int charCount, bool flushout , System.Int32& bytesUsedout , System.Int32& charsUsedout , System.Boolean& completed) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public DecoderFallback Fallback { get{} set{} }
	public DecoderFallbackBuffer FallbackBuffer { get{} }
}


public class Encoding : System.ICloneable
{

	// Methods
	public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes) {}
	public static byte[] Convert(Encoding srcEncoding, Encoding dstEncoding, byte[] bytes, int index, int count) {}
	public static Encoding GetEncoding(int codepage) {}
	public static Encoding GetEncoding(int codepage, EncoderFallback encoderFallback, DecoderFallback decoderFallback) {}
	public static Encoding GetEncoding(string name) {}
	public static Encoding GetEncoding(string name, EncoderFallback encoderFallback, DecoderFallback decoderFallback) {}
	public static EncodingInfo[] GetEncodings() {}
	public virtual byte[] GetPreamble() {}
	public virtual object Clone() {}
	public virtual int GetByteCount(char[] chars) {}
	public virtual int GetByteCount(string s) {}
	public abstract virtual int GetByteCount(char[] chars, int index, int count) {}
	public virtual int GetByteCount(System.Char* chars, int count) {}
	public virtual byte[] GetBytes(char[] chars) {}
	public virtual byte[] GetBytes(char[] chars, int index, int count) {}
	public abstract virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) {}
	public virtual byte[] GetBytes(string s) {}
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) {}
	public virtual int GetBytes(System.Char* chars, int charCount, System.Byte* bytes, int byteCount) {}
	public virtual int GetCharCount(byte[] bytes) {}
	public abstract virtual int GetCharCount(byte[] bytes, int index, int count) {}
	public virtual int GetCharCount(System.Byte* bytes, int count) {}
	public virtual char[] GetChars(byte[] bytes) {}
	public virtual char[] GetChars(byte[] bytes, int index, int count) {}
	public abstract virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) {}
	public virtual int GetChars(System.Byte* bytes, int byteCount, System.Char* chars, int charCount) {}
	public bool IsAlwaysNormalized() {}
	public virtual bool IsAlwaysNormalized(NormalizationForm form) {}
	public virtual Decoder GetDecoder() {}
	public virtual Encoder GetEncoder() {}
	public abstract virtual int GetMaxByteCount(int charCount) {}
	public abstract virtual int GetMaxCharCount(int byteCount) {}
	public virtual string GetString(byte[] bytes) {}
	public virtual string GetString(byte[] bytes, int index, int count) {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string BodyName { get{} }
	public string EncodingName { get{} }
	public string HeaderName { get{} }
	public string WebName { get{} }
	public int WindowsCodePage { get{} }
	public bool IsBrowserDisplay { get{} }
	public bool IsBrowserSave { get{} }
	public bool IsMailNewsDisplay { get{} }
	public bool IsMailNewsSave { get{} }
	public bool IsSingleByte { get{} }
	public EncoderFallback EncoderFallback { get{} set{} }
	public DecoderFallback DecoderFallback { get{} set{} }
	public bool IsReadOnly { get{} }
	public Encoding ASCII { get{} }
	public int CodePage { get{} }
	public Encoding Default { get{} }
	public Encoding Unicode { get{} }
	public Encoding BigEndianUnicode { get{} }
	public Encoding UTF7 { get{} }
	public Encoding UTF8 { get{} }
	public Encoding UTF32 { get{} }
}


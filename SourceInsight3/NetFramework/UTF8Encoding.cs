public class UTF8Encoding : Encoding, System.ICloneable
{

	// Constructors
	public UTF8Encoding() {}
	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier) {}
	public UTF8Encoding(bool encoderShouldEmitUTF8Identifier, bool throwOnInvalidBytes) {}

	// Methods
	public virtual int GetByteCount(char[] chars, int index, int count) {}
	public virtual int GetByteCount(string chars) {}
	public virtual int GetByteCount(System.Char* chars, int count) {}
	public virtual int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) {}
	public virtual int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) {}
	public virtual int GetBytes(System.Char* chars, int charCount, System.Byte* bytes, int byteCount) {}
	public virtual int GetCharCount(byte[] bytes, int index, int count) {}
	public virtual int GetCharCount(System.Byte* bytes, int count) {}
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) {}
	public virtual int GetChars(System.Byte* bytes, int byteCount, System.Char* chars, int charCount) {}
	public virtual string GetString(byte[] bytes, int index, int count) {}
	public virtual Decoder GetDecoder() {}
	public virtual Encoder GetEncoder() {}
	public virtual int GetMaxByteCount(int charCount) {}
	public virtual int GetMaxCharCount(int byteCount) {}
	public virtual byte[] GetPreamble() {}
	public virtual bool Equals(object value) {}
	public virtual int GetHashCode() {}
	public virtual object Clone() {}
	public virtual int GetByteCount(char[] chars) {}
	public virtual byte[] GetBytes(char[] chars) {}
	public virtual byte[] GetBytes(char[] chars, int index, int count) {}
	public virtual byte[] GetBytes(string s) {}
	public virtual int GetCharCount(byte[] bytes) {}
	public virtual char[] GetChars(byte[] bytes) {}
	public virtual char[] GetChars(byte[] bytes, int index, int count) {}
	public bool IsAlwaysNormalized() {}
	public virtual bool IsAlwaysNormalized(NormalizationForm form) {}
	public virtual string GetString(byte[] bytes) {}
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
	public int CodePage { get{} }
}


public class TextFieldParser : System.IDisposable
{

	// Constructors
	public TextFieldParser(string path) {}
	public TextFieldParser(string path, System.Text.Encoding defaultEncoding) {}
	public TextFieldParser(string path, System.Text.Encoding defaultEncoding, bool detectEncoding) {}
	public TextFieldParser(System.IO.Stream stream) {}
	public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding) {}
	public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding, bool detectEncoding) {}
	public TextFieldParser(System.IO.Stream stream, System.Text.Encoding defaultEncoding, bool detectEncoding, bool leaveOpen) {}
	public TextFieldParser(System.IO.TextReader reader) {}

	// Methods
	public virtual void Dispose() {}
	public void SetDelimiters(string[] delimiters) {}
	public void SetFieldWidths(int[] fieldWidths) {}
	public string ReadLine() {}
	public string[] ReadFields() {}
	public string PeekChars(int numberOfChars) {}
	public string ReadToEnd() {}
	public void Close() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string[] CommentTokens { get{} set{} }
	public bool EndOfData { get{} }
	public long LineNumber { get{} }
	public string ErrorLine { get{} }
	public long ErrorLineNumber { get{} }
	public FieldType TextFieldType { get{} set{} }
	public int[] FieldWidths { get{} set{} }
	public string[] Delimiters { get{} set{} }
	public bool TrimWhiteSpace { get{} set{} }
	public bool HasFieldsEnclosedInQuotes { get{} set{} }
}


public class StreamReader : TextReader, System.IDisposable
{

	// Constructors
	public StreamReader(Stream stream, System.Text.Encoding encoding) {}
	public StreamReader(Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) {}
	public StreamReader(string path, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks) {}
	public StreamReader(Stream stream) {}
	public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks) {}
	public StreamReader(Stream stream, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks) {}
	public StreamReader(string path) {}
	public StreamReader(string path, bool detectEncodingFromByteOrderMarks) {}
	public StreamReader(string path, System.Text.Encoding encoding) {}
	public StreamReader(string path, System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) {}

	// Methods
	public virtual void Close() {}
	public void DiscardBufferedData() {}
	public virtual int Peek() {}
	public virtual int Read() {}
	public virtual int Read(out char[] buffer, int index, int count) {}
	public virtual string ReadToEnd() {}
	public virtual string ReadLine() {}
	public virtual void Dispose() {}
	public virtual int ReadBlock(out char[] buffer, int index, int count) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public StreamReader Null;

	// Properties
	public System.Text.Encoding CurrentEncoding { get{} }
	public Stream BaseStream { get{} }
	public bool EndOfStream { get{} }
}


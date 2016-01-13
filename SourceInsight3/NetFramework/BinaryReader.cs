public class BinaryReader : System.IDisposable
{

	// Constructors
	public BinaryReader(Stream input) {}
	public BinaryReader(Stream input, System.Text.Encoding encoding) {}

	// Methods
	public virtual void Close() {}
	public virtual int PeekChar() {}
	public virtual int Read() {}
	public virtual bool ReadBoolean() {}
	public virtual byte ReadByte() {}
	public virtual System.SByte ReadSByte() {}
	public virtual char ReadChar() {}
	public virtual short ReadInt16() {}
	public virtual ushort ReadUInt16() {}
	public virtual int ReadInt32() {}
	public virtual uint ReadUInt32() {}
	public virtual long ReadInt64() {}
	public virtual ulong ReadUInt64() {}
	public virtual float ReadSingle() {}
	public virtual double ReadDouble() {}
	public virtual decimal ReadDecimal() {}
	public virtual string ReadString() {}
	public virtual int Read(char[] buffer, int index, int count) {}
	public virtual char[] ReadChars(int count) {}
	public virtual int Read(byte[] buffer, int index, int count) {}
	public virtual byte[] ReadBytes(int count) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Stream BaseStream { get{} }
}


public class BinaryWriter : System.IDisposable
{

	// Constructors
	public BinaryWriter(Stream output) {}
	public BinaryWriter(Stream output, System.Text.Encoding encoding) {}

	// Methods
	public virtual void Close() {}
	public virtual void Flush() {}
	public virtual long Seek(int offset, SeekOrigin origin) {}
	public virtual void Write(bool value) {}
	public virtual void Write(byte value) {}
	public virtual void Write(System.SByte value) {}
	public virtual void Write(byte[] buffer) {}
	public virtual void Write(byte[] buffer, int index, int count) {}
	public virtual void Write(char ch) {}
	public virtual void Write(char[] chars) {}
	public virtual void Write(char[] chars, int index, int count) {}
	public virtual void Write(double value) {}
	public virtual void Write(decimal value) {}
	public virtual void Write(short value) {}
	public virtual void Write(ushort value) {}
	public virtual void Write(int value) {}
	public virtual void Write(uint value) {}
	public virtual void Write(long value) {}
	public virtual void Write(ulong value) {}
	public virtual void Write(float value) {}
	public virtual void Write(string value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public BinaryWriter Null;

	// Properties
	public Stream BaseStream { get{} }
}


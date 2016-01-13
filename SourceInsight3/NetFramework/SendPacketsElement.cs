public class SendPacketsElement
{

	// Constructors
	public SendPacketsElement(string filepath) {}
	public SendPacketsElement(string filepath, int offset, int count) {}
	public SendPacketsElement(string filepath, int offset, int count, bool endOfPacket) {}
	public SendPacketsElement(byte[] buffer) {}
	public SendPacketsElement(byte[] buffer, int offset, int count) {}
	public SendPacketsElement(byte[] buffer, int offset, int count, bool endOfPacket) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string FilePath { get{} }
	public byte[] Buffer { get{} }
	public int Count { get{} }
	public int Offset { get{} }
	public bool EndOfPacket { get{} }
}


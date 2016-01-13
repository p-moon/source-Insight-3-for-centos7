public class AsnEncodedData
{

	// Constructors
	public AsnEncodedData(byte[] rawData) {}
	public AsnEncodedData(string oid, byte[] rawData) {}
	public AsnEncodedData(Oid oid, byte[] rawData) {}
	public AsnEncodedData(AsnEncodedData asnEncodedData) {}

	// Methods
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) {}
	public virtual string Format(bool multiLine) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Oid Oid { get{} set{} }
	public byte[] RawData { get{} set{} }
}


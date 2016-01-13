public class CryptographicAttributeObject
{

	// Constructors
	public CryptographicAttributeObject(Oid oid) {}
	public CryptographicAttributeObject(Oid oid, AsnEncodedDataCollection values) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public Oid Oid { get{} }
	public AsnEncodedDataCollection Values { get{} }
}


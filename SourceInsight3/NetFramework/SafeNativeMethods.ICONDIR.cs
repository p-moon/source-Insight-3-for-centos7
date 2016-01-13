public class ICONDIR : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public short idReserved;
	public short idType;
	public short idCount;
	public ICONDIRENTRY idEntries;
}


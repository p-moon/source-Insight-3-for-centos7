public class RGNDATAHEADER : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public int cbSizeOfStruct;
	public int iType;
	public int nCount;
	public int nRgnSize;
}


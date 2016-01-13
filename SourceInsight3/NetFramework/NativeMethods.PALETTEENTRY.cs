public class PALETTEENTRY : System.ValueType
{

	// Methods
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public virtual string ToString() {}
	public Type GetType() {}

	// Fields
	public byte peRed;
	public byte peGreen;
	public byte peBlue;
	public byte peFlags;
}


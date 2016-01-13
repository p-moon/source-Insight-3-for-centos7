public class FONTDESC
{

	// Constructors
	public FONTDESC() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSizeOfStruct;
	public string lpstrName;
	public long cySize;
	public short sWeight;
	public short sCharset;
	public bool fItalic;
	public bool fUnderline;
	public bool fStrikethrough;
}


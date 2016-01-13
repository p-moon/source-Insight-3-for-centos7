public class CHARFORMAT2A
{

	// Constructors
	public CHARFORMAT2A() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int cbSize;
	public int dwMask;
	public int dwEffects;
	public int yHeight;
	public int yOffset;
	public int crTextColor;
	public byte bCharSet;
	public byte bPitchAndFamily;
	public byte[] szFaceName;
	public short wWeight;
	public short sSpacing;
	public int crBackColor;
	public int lcid;
	public int dwReserved;
	public short sStyle;
	public short wKerning;
	public byte bUnderlineType;
	public byte bAnimation;
	public byte bRevAuthor;
}


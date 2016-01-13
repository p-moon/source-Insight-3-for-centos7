public class CHARFORMATW
{

	// Constructors
	public CHARFORMATW() {}

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
}


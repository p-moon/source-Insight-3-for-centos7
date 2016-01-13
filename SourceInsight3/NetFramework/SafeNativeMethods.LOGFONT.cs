public class LOGFONT
{

	// Constructors
	public LOGFONT() {}
	public LOGFONT(LOGFONT lf) {}

	// Methods
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int lfHeight;
	public int lfWidth;
	public int lfEscapement;
	public int lfOrientation;
	public int lfWeight;
	public byte lfItalic;
	public byte lfUnderline;
	public byte lfStrikeOut;
	public byte lfCharSet;
	public byte lfOutPrecision;
	public byte lfClipPrecision;
	public byte lfQuality;
	public byte lfPitchAndFamily;
	public string lfFaceName;
}


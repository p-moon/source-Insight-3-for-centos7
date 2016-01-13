public class DRAWTEXTPARAMS
{

	// Constructors
	public DRAWTEXTPARAMS() {}
	public DRAWTEXTPARAMS(DRAWTEXTPARAMS original) {}
	public DRAWTEXTPARAMS(int leftMargin, int rightMargin) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int iTabLength;
	public int iLeftMargin;
	public int iRightMargin;
	public int uiLengthDrawn;
}


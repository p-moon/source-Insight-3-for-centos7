public interface IFont
{

	// Methods
	public abstract virtual string GetName() {}
	public abstract virtual void SetName(string pname) {}
	public abstract virtual long GetSize() {}
	public abstract virtual void SetSize(long psize) {}
	public abstract virtual bool GetBold() {}
	public abstract virtual void SetBold(bool pbold) {}
	public abstract virtual bool GetItalic() {}
	public abstract virtual void SetItalic(bool pitalic) {}
	public abstract virtual bool GetUnderline() {}
	public abstract virtual void SetUnderline(bool punderline) {}
	public abstract virtual bool GetStrikethrough() {}
	public abstract virtual void SetStrikethrough(bool pstrikethrough) {}
	public abstract virtual short GetWeight() {}
	public abstract virtual void SetWeight(short pweight) {}
	public abstract virtual short GetCharset() {}
	public abstract virtual void SetCharset(short pcharset) {}
	public abstract virtual System.IntPtr GetHFont() {}
	public abstract virtual void Clone(out IFont& ppfont) {}
	public abstract virtual int IsEqual(IFont pfontOther) {}
	public abstract virtual void SetRatio(int cyLogical, int cyHimetric) {}
	public abstract virtual void QueryTextMetrics(out System.IntPtr& ptm) {}
	public abstract virtual void AddRefHfont(System.IntPtr hFont) {}
	public abstract virtual void ReleaseHfont(System.IntPtr hFont) {}
	public abstract virtual void SetHdc(System.IntPtr hdc) {}
}


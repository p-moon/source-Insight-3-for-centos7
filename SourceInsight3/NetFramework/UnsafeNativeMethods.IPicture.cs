public interface IPicture
{

	// Methods
	public abstract virtual System.IntPtr GetHandle() {}
	public abstract virtual System.IntPtr GetHPal() {}
	public abstract virtual short GetPictureType() {}
	public abstract virtual int GetWidth() {}
	public abstract virtual int GetHeight() {}
	public abstract virtual void Render(System.IntPtr hDC, int x, int y, int cx, int cy, int xSrc, int ySrc, int cxSrc, int cySrc, System.IntPtr rcBounds) {}
	public abstract virtual void SetHPal(System.IntPtr phpal) {}
	public abstract virtual System.IntPtr GetCurDC() {}
	public abstract virtual void SelectPicture(System.IntPtr hdcInout , System.IntPtr[] phdcOutout , System.IntPtr[] phbmpOut) {}
	public abstract virtual bool GetKeepOriginalFormat() {}
	public abstract virtual void SetKeepOriginalFormat(bool pfkeep) {}
	public abstract virtual void PictureChanged() {}
	public abstract virtual int SaveAsFile(IStream pstm, int fSaveMemCopyout , System.Int32& pcbSize) {}
	public abstract virtual int GetAttributes() {}
}


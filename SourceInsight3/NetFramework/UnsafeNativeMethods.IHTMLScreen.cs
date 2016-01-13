public interface IHTMLScreen
{

	// Methods
	public abstract virtual int GetColorDepth() {}
	public abstract virtual void SetBufferDepth(int d) {}
	public abstract virtual int GetBufferDepth() {}
	public abstract virtual int GetWidth() {}
	public abstract virtual int GetHeight() {}
	public abstract virtual void SetUpdateInterval(int i) {}
	public abstract virtual int GetUpdateInterval() {}
	public abstract virtual int GetAvailHeight() {}
	public abstract virtual int GetAvailWidth() {}
	public abstract virtual bool GetFontSmoothingEnabled() {}
}


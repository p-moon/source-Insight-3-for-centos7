public interface IOleWindow
{

	// Methods
	public abstract virtual int GetWindow(out System.IntPtr& hwnd) {}
	public abstract virtual void ContextSensitiveHelp(int fEnterMode) {}
}


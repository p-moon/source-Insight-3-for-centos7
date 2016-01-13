public interface DWebBrowserEvents2
{

	// Methods
	public abstract virtual void StatusTextChange(string text) {}
	public abstract virtual void ProgressChange(int progress, int progressMax) {}
	public abstract virtual void CommandStateChange(long command, bool enable) {}
	public abstract virtual void DownloadBegin() {}
	public abstract virtual void DownloadComplete() {}
	public abstract virtual void TitleChange(string text) {}
	public abstract virtual void PropertyChange(string szProperty) {}
	public abstract virtual void BeforeNavigate2(object pDisp, System.Object& URL, System.Object& flags, System.Object& targetFrameName, System.Object& postData, System.Object& headersout , System.Boolean& cancel) {}
	public abstract virtual void NewWindow2(out System.Object& pDispout , System.Boolean& cancel) {}
	public abstract virtual void NavigateComplete2(object pDisp, System.Object& URL) {}
	public abstract virtual void DocumentComplete(object pDisp, System.Object& URL) {}
	public abstract virtual void OnQuit() {}
	public abstract virtual void OnVisible(bool visible) {}
	public abstract virtual void OnToolBar(bool toolBar) {}
	public abstract virtual void OnMenuBar(bool menuBar) {}
	public abstract virtual void OnStatusBar(bool statusBar) {}
	public abstract virtual void OnFullScreen(bool fullScreen) {}
	public abstract virtual void OnTheaterMode(bool theaterMode) {}
	public abstract virtual void WindowSetResizable(bool resizable) {}
	public abstract virtual void WindowSetLeft(int left) {}
	public abstract virtual void WindowSetTop(int top) {}
	public abstract virtual void WindowSetWidth(int width) {}
	public abstract virtual void WindowSetHeight(int height) {}
	public abstract virtual void WindowClosing(bool isChildWindowout , System.Boolean& cancel) {}
	public abstract virtual void ClientToHostWindow(out System.Int64& cxout , System.Int64& cy) {}
	public abstract virtual void SetSecureLockIcon(int secureLockIcon) {}
	public abstract virtual void FileDownload(out System.Boolean& cancel) {}
	public abstract virtual void NavigateError(object pDisp, System.Object& URL, System.Object& frame, System.Object& statusCodeout , System.Boolean& cancel) {}
	public abstract virtual void PrintTemplateInstantiation(object pDisp) {}
	public abstract virtual void PrintTemplateTeardown(object pDisp) {}
	public abstract virtual void UpdatePageStatus(object pDisp, System.Object& nPage, System.Object& fDone) {}
	public abstract virtual void PrivacyImpactedStateChange(bool bImpacted) {}
}


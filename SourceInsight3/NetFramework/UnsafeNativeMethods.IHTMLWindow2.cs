public interface IHTMLWindow2
{

	// Methods
	public abstract virtual void ScrollBy(int x, int y) {}
	public abstract virtual void ScrollTo(int x, int y) {}
	public abstract virtual void MoveTo(int x, int y) {}
	public abstract virtual void MoveBy(int x, int y) {}
	public abstract virtual void ResizeTo(int x, int y) {}
	public abstract virtual void ResizeBy(int x, int y) {}
	public abstract virtual object GetExternal() {}
	public abstract virtual object Item(System.Object& pvarIndex) {}
	public abstract virtual int GetLength() {}
	public abstract virtual IHTMLFramesCollection2 GetFrames() {}
	public abstract virtual void SetDefaultStatus(string p) {}
	public abstract virtual string GetDefaultStatus() {}
	public abstract virtual void SetStatus(string p) {}
	public abstract virtual string GetStatus() {}
	public abstract virtual int SetTimeout(string expression, int msec, System.Object& language) {}
	public abstract virtual void ClearTimeout(int timerID) {}
	public abstract virtual void Alert(string message) {}
	public abstract virtual bool Confirm(string message) {}
	public abstract virtual object Prompt(string message, string defstr) {}
	public abstract virtual object GetImage() {}
	public abstract virtual IHTMLLocation GetLocation() {}
	public abstract virtual IOmHistory GetHistory() {}
	public abstract virtual void Close() {}
	public abstract virtual void SetOpener(object p) {}
	public abstract virtual object GetOpener() {}
	public abstract virtual IOmNavigator GetNavigator() {}
	public abstract virtual void SetName(string p) {}
	public abstract virtual string GetName() {}
	public abstract virtual IHTMLWindow2 GetParent() {}
	public abstract virtual IHTMLWindow2 Open(string URL, string name, string features, bool replace) {}
	public abstract virtual object GetSelf() {}
	public abstract virtual object GetTop() {}
	public abstract virtual object GetWindow() {}
	public abstract virtual void Navigate(string URL) {}
	public abstract virtual void SetOnfocus(object p) {}
	public abstract virtual object GetOnfocus() {}
	public abstract virtual void SetOnblur(object p) {}
	public abstract virtual object GetOnblur() {}
	public abstract virtual void SetOnload(object p) {}
	public abstract virtual object GetOnload() {}
	public abstract virtual void SetOnbeforeunload(object p) {}
	public abstract virtual object GetOnbeforeunload() {}
	public abstract virtual void SetOnunload(object p) {}
	public abstract virtual object GetOnunload() {}
	public abstract virtual void SetOnhelp(object p) {}
	public abstract virtual object GetOnhelp() {}
	public abstract virtual void SetOnerror(object p) {}
	public abstract virtual object GetOnerror() {}
	public abstract virtual void SetOnresize(object p) {}
	public abstract virtual object GetOnresize() {}
	public abstract virtual void SetOnscroll(object p) {}
	public abstract virtual object GetOnscroll() {}
	public abstract virtual IHTMLDocument2 GetDocument() {}
	public abstract virtual IHTMLEventObj GetEvent() {}
	public abstract virtual object Get_newEnum() {}
	public abstract virtual object ShowModalDialog(string dialog, System.Object& varArgIn, System.Object& varOptions) {}
	public abstract virtual void ShowHelp(string helpURL, object helpArg, string features) {}
	public abstract virtual IHTMLScreen GetScreen() {}
	public abstract virtual object GetOption() {}
	public abstract virtual void Focus() {}
	public abstract virtual bool GetClosed() {}
	public abstract virtual void Blur() {}
	public abstract virtual void Scroll(int x, int y) {}
	public abstract virtual object GetClientInformation() {}
	public abstract virtual int SetInterval(string expression, int msec, System.Object& language) {}
	public abstract virtual void ClearInterval(int timerID) {}
	public abstract virtual void SetOffscreenBuffering(object p) {}
	public abstract virtual object GetOffscreenBuffering() {}
	public abstract virtual object ExecScript(string code, string language) {}
	public abstract virtual string toString() {}
}


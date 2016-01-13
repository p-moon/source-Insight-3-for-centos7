public interface IWebBrowser2
{

	// Methods
	public abstract virtual void GoBack() {}
	public abstract virtual void GoForward() {}
	public abstract virtual void GoHome() {}
	public abstract virtual void GoSearch() {}
	public abstract virtual void Navigate(string Url, System.Object& flags, System.Object& targetFrameName, System.Object& postData, System.Object& headers) {}
	public abstract virtual void Refresh() {}
	public abstract virtual void Refresh2(System.Object& level) {}
	public abstract virtual void Stop() {}
	public abstract virtual void Quit() {}
	public abstract virtual void ClientToWindow(out System.Int32& pcxout , System.Int32& pcy) {}
	public abstract virtual void PutProperty(string property, object vtValue) {}
	public abstract virtual object GetProperty(string property) {}
	public abstract virtual void Navigate2(System.Object& URL, System.Object& flags, System.Object& targetFrameName, System.Object& postData, System.Object& headers) {}
	public abstract virtual OLECMDF QueryStatusWB(OLECMDID cmdID) {}
	public abstract virtual void ExecWB(OLECMDID cmdID, OLECMDEXECOPT cmdexecopt, System.Object& pvaIn, System.IntPtr pvaOut) {}
	public abstract virtual void ShowBrowserBar(System.Object& pvaClsid, System.Object& pvarShow, System.Object& pvarSize) {}

	// Properties
	public object Application { get{} }
	public object Parent { get{} }
	public object Container { get{} }
	public object Document { get{} }
	public bool TopLevelContainer { get{} }
	public string Type { get{} }
	public int Left { get{} set{} }
	public int Top { get{} set{} }
	public int Width { get{} set{} }
	public int Height { get{} set{} }
	public string LocationName { get{} }
	public string LocationURL { get{} }
	public bool Busy { get{} }
	public string Name { get{} }
	public int HWND { get{} }
	public string FullName { get{} }
	public string Path { get{} }
	public bool Visible { get{} set{} }
	public bool StatusBar { get{} set{} }
	public string StatusText { get{} set{} }
	public int ToolBar { get{} set{} }
	public bool MenuBar { get{} set{} }
	public bool FullScreen { get{} set{} }
	public WebBrowserReadyState ReadyState { get{} }
	public bool Offline { get{} set{} }
	public bool Silent { get{} set{} }
	public bool RegisterAsBrowser { get{} set{} }
	public bool RegisterAsDropTarget { get{} set{} }
	public bool TheaterMode { get{} set{} }
	public bool AddressBar { get{} set{} }
	public bool Resizable { get{} set{} }
}


public interface IHTMLDocument2
{

	// Methods
	public abstract virtual bool ExecCommand(string cmdID, bool showUI, object value) {}
	public abstract virtual bool ExecCommandShowHelp(string cmdID) {}
	public abstract virtual IHTMLElement CreateElement(string eTag) {}
	public abstract virtual void SetOnhelp(object p) {}
	public abstract virtual object GetOnhelp() {}
	public abstract virtual void SetOnclick(object p) {}
	public abstract virtual object GetOnclick() {}
	public abstract virtual void SetOndblclick(object p) {}
	public abstract virtual object GetOndblclick() {}
	public abstract virtual void SetOnkeyup(object p) {}
	public abstract virtual object GetOnkeyup() {}
	public abstract virtual void SetOnkeydown(object p) {}
	public abstract virtual object GetOnkeydown() {}
	public abstract virtual void SetOnkeypress(object p) {}
	public abstract virtual object GetOnkeypress() {}
	public abstract virtual void SetOnmouseup(object p) {}
	public abstract virtual object GetOnmouseup() {}
	public abstract virtual void SetOnmousedown(object p) {}
	public abstract virtual object GetOnmousedown() {}
	public abstract virtual void SetOnmousemove(object p) {}
	public abstract virtual object GetOnmousemove() {}
	public abstract virtual void SetOnmouseout(object p) {}
	public abstract virtual object GetOnmouseout() {}
	public abstract virtual void SetOnmouseover(object p) {}
	public abstract virtual object GetOnmouseover() {}
	public abstract virtual void SetOnreadystatechange(object p) {}
	public abstract virtual object GetOnreadystatechange() {}
	public abstract virtual void SetOnafterupdate(object p) {}
	public abstract virtual object GetOnafterupdate() {}
	public abstract virtual void SetOnrowexit(object p) {}
	public abstract virtual object GetOnrowexit() {}
	public abstract virtual void SetOnrowenter(object p) {}
	public abstract virtual object GetOnrowenter() {}
	public abstract virtual void SetOndragstart(object p) {}
	public abstract virtual object GetOndragstart() {}
	public abstract virtual void SetOnselectstart(object p) {}
	public abstract virtual object GetOnselectstart() {}
	public abstract virtual IHTMLElement ElementFromPoint(int x, int y) {}
	public abstract virtual object GetParentWindow() {}
	public abstract virtual object GetStyleSheets() {}
	public abstract virtual void SetOnbeforeupdate(object p) {}
	public abstract virtual object GetOnbeforeupdate() {}
	public abstract virtual void SetOnerrorupdate(object p) {}
	public abstract virtual object GetOnerrorupdate() {}
	public abstract virtual string toString() {}
	public abstract virtual IHTMLStyleSheet CreateStyleSheet(string bstrHref, int lIndex) {}
	public abstract virtual object GetScript() {}
	public abstract virtual IHTMLElementCollection GetAll() {}
	public abstract virtual IHTMLElement GetBody() {}
	public abstract virtual IHTMLElement GetActiveElement() {}
	public abstract virtual IHTMLElementCollection GetImages() {}
	public abstract virtual IHTMLElementCollection GetApplets() {}
	public abstract virtual IHTMLElementCollection GetLinks() {}
	public abstract virtual IHTMLElementCollection GetForms() {}
	public abstract virtual IHTMLElementCollection GetAnchors() {}
	public abstract virtual void SetTitle(string p) {}
	public abstract virtual string GetTitle() {}
	public abstract virtual IHTMLElementCollection GetScripts() {}
	public abstract virtual void SetDesignMode(string p) {}
	public abstract virtual string GetDesignMode() {}
	public abstract virtual object GetSelection() {}
	public abstract virtual string GetReadyState() {}
	public abstract virtual object GetFrames() {}
	public abstract virtual IHTMLElementCollection GetEmbeds() {}
	public abstract virtual IHTMLElementCollection GetPlugins() {}
	public abstract virtual void SetAlinkColor(object p) {}
	public abstract virtual object GetAlinkColor() {}
	public abstract virtual void SetBgColor(object p) {}
	public abstract virtual object GetBgColor() {}
	public abstract virtual void SetFgColor(object p) {}
	public abstract virtual object GetFgColor() {}
	public abstract virtual void SetLinkColor(object p) {}
	public abstract virtual object GetLinkColor() {}
	public abstract virtual void SetVlinkColor(object p) {}
	public abstract virtual object GetVlinkColor() {}
	public abstract virtual string GetReferrer() {}
	public abstract virtual object GetLocation() {}
	public abstract virtual string GetLastModified() {}
	public abstract virtual void SetURL(string p) {}
	public abstract virtual string GetURL() {}
	public abstract virtual void SetDomain(string p) {}
	public abstract virtual string GetDomain() {}
	public abstract virtual void SetCookie(string p) {}
	public abstract virtual string GetCookie() {}
	public abstract virtual void SetExpando(bool p) {}
	public abstract virtual bool GetExpando() {}
	public abstract virtual void SetCharset(string p) {}
	public abstract virtual string GetCharset() {}
	public abstract virtual void SetDefaultCharset(string p) {}
	public abstract virtual string GetDefaultCharset() {}
	public abstract virtual string GetMimeType() {}
	public abstract virtual string GetFileSize() {}
	public abstract virtual string GetFileCreatedDate() {}
	public abstract virtual string GetFileModifiedDate() {}
	public abstract virtual string GetFileUpdatedDate() {}
	public abstract virtual string GetSecurity() {}
	public abstract virtual string GetProtocol() {}
	public abstract virtual string GetNameProp() {}
	public abstract virtual void DummyWrite(int psarray) {}
	public abstract virtual void DummyWriteln(int psarray) {}
	public abstract virtual object Open(string URL, object name, object features, object replace) {}
	public abstract virtual void Close() {}
	public abstract virtual void Clear() {}
	public abstract virtual bool QueryCommandSupported(string cmdID) {}
	public abstract virtual bool QueryCommandEnabled(string cmdID) {}
	public abstract virtual bool QueryCommandState(string cmdID) {}
	public abstract virtual bool QueryCommandIndeterm(string cmdID) {}
	public abstract virtual string QueryCommandText(string cmdID) {}
	public abstract virtual object QueryCommandValue(string cmdID) {}
}


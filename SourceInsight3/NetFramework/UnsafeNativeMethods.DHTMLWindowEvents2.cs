public interface DHTMLWindowEvents2
{

	// Methods
	public abstract virtual void onload(IHTMLEventObj evtObj) {}
	public abstract virtual void onunload(IHTMLEventObj evtObj) {}
	public abstract virtual bool onhelp(IHTMLEventObj evtObj) {}
	public abstract virtual void onfocus(IHTMLEventObj evtObj) {}
	public abstract virtual void onblur(IHTMLEventObj evtObj) {}
	public abstract virtual bool onerror(string description, string url, int line) {}
	public abstract virtual void onresize(IHTMLEventObj evtObj) {}
	public abstract virtual void onscroll(IHTMLEventObj evtObj) {}
	public abstract virtual void onbeforeunload(IHTMLEventObj evtObj) {}
	public abstract virtual void onbeforeprint(IHTMLEventObj evtObj) {}
	public abstract virtual void onafterprint(IHTMLEventObj evtObj) {}
}


public interface IHTMLElement
{

	// Methods
	public abstract virtual object GetFilters() {}
	public abstract virtual void SetOndragstart(object p) {}
	public abstract virtual object GetOndragstart() {}
	public abstract virtual string toString() {}
	public abstract virtual void SetOnbeforeupdate(object p) {}
	public abstract virtual object GetOnbeforeupdate() {}
	public abstract virtual void SetOnafterupdate(object p) {}
	public abstract virtual object GetOnafterupdate() {}
	public abstract virtual void SetOnerrorupdate(object p) {}
	public abstract virtual object GetOnerrorupdate() {}
	public abstract virtual void SetOnrowexit(object p) {}
	public abstract virtual object GetOnrowexit() {}
	public abstract virtual void SetOnrowenter(object p) {}
	public abstract virtual object GetOnrowenter() {}
	public abstract virtual void SetOndatasetchanged(object p) {}
	public abstract virtual object GetOndatasetchanged() {}
	public abstract virtual void SetOndataavailable(object p) {}
	public abstract virtual object GetOndataavailable() {}
	public abstract virtual void SetOndatasetcomplete(object p) {}
	public abstract virtual object GetOndatasetcomplete() {}
	public abstract virtual void SetOnfilterchange(object p) {}
	public abstract virtual object GetOnfilterchange() {}
	public abstract virtual object GetChildren() {}
	public abstract virtual object GetAll() {}
	public abstract virtual void SetAttribute(string strAttributeName, object AttributeValue, int lFlags) {}
	public abstract virtual void GetAttribute(string strAttributeName, int lFlagsout , object[] pvars) {}
	public abstract virtual bool RemoveAttribute(string strAttributeName, int lFlags) {}
	public abstract virtual void SetClassName(string p) {}
	public abstract virtual string GetClassName() {}
	public abstract virtual void SetId(string p) {}
	public abstract virtual string GetId() {}
	public abstract virtual string GetTagName() {}
	public abstract virtual IHTMLElement GetParentElement() {}
	public abstract virtual IHTMLStyle GetStyle() {}
	public abstract virtual void SetOnhelp(object p) {}
	public abstract virtual object GetOnhelp() {}
	public abstract virtual void SetOnclick(object p) {}
	public abstract virtual object GetOnclick() {}
	public abstract virtual void SetOndblclick(object p) {}
	public abstract virtual object GetOndblclick() {}
	public abstract virtual void SetOnkeydown(object p) {}
	public abstract virtual object GetOnkeydown() {}
	public abstract virtual void SetOnkeyup(object p) {}
	public abstract virtual object GetOnkeyup() {}
	public abstract virtual void SetOnkeypress(object p) {}
	public abstract virtual object GetOnkeypress() {}
	public abstract virtual void SetOnmouseout(object p) {}
	public abstract virtual object GetOnmouseout() {}
	public abstract virtual void SetOnmouseover(object p) {}
	public abstract virtual object GetOnmouseover() {}
	public abstract virtual void SetOnmousemove(object p) {}
	public abstract virtual object GetOnmousemove() {}
	public abstract virtual void SetOnmousedown(object p) {}
	public abstract virtual object GetOnmousedown() {}
	public abstract virtual void SetOnmouseup(object p) {}
	public abstract virtual object GetOnmouseup() {}
	public abstract virtual IHTMLDocument2 GetDocument() {}
	public abstract virtual void SetTitle(string p) {}
	public abstract virtual string GetTitle() {}
	public abstract virtual void SetLanguage(string p) {}
	public abstract virtual string GetLanguage() {}
	public abstract virtual void SetOnselectstart(object p) {}
	public abstract virtual object GetOnselectstart() {}
	public abstract virtual void ScrollIntoView(object varargStart) {}
	public abstract virtual bool Contains(IHTMLElement pChild) {}
	public abstract virtual int GetSourceIndex() {}
	public abstract virtual object GetRecordNumber() {}
	public abstract virtual void SetLang(string p) {}
	public abstract virtual string GetLang() {}
	public abstract virtual int GetOffsetLeft() {}
	public abstract virtual int GetOffsetTop() {}
	public abstract virtual int GetOffsetWidth() {}
	public abstract virtual int GetOffsetHeight() {}
	public abstract virtual IHTMLElement GetOffsetParent() {}
	public abstract virtual void SetInnerHTML(string p) {}
	public abstract virtual string GetInnerHTML() {}
	public abstract virtual void SetInnerText(string p) {}
	public abstract virtual string GetInnerText() {}
	public abstract virtual void SetOuterHTML(string p) {}
	public abstract virtual string GetOuterHTML() {}
	public abstract virtual void SetOuterText(string p) {}
	public abstract virtual string GetOuterText() {}
	public abstract virtual void InsertAdjacentHTML(string where, string html) {}
	public abstract virtual void InsertAdjacentText(string where, string text) {}
	public abstract virtual IHTMLElement GetParentTextEdit() {}
	public abstract virtual bool GetIsTextEdit() {}
	public abstract virtual void Click() {}
}


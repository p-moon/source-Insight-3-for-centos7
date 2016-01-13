public interface IHTMLElement2
{

	// Methods
	public abstract virtual object GetOnreadystatechange() {}
	public abstract virtual void SetOnrowsdelete(object p) {}
	public abstract virtual object GetOnrowsdelete() {}
	public abstract virtual void SetOnrowsinserted(object p) {}
	public abstract virtual object GetOnrowsinserted() {}
	public abstract virtual void SetOncellchange(object p) {}
	public abstract virtual object GetOncellchange() {}
	public abstract virtual void SetDir(string p) {}
	public abstract virtual string GetDir() {}
	public abstract virtual object CreateControlRange() {}
	public abstract virtual int GetScrollHeight() {}
	public abstract virtual int GetScrollWidth() {}
	public abstract virtual void SetScrollTop(int p) {}
	public abstract virtual int GetScrollTop() {}
	public abstract virtual void SetScrollLeft(int p) {}
	public abstract virtual int GetScrollLeft() {}
	public abstract virtual void ClearAttributes() {}
	public abstract virtual void MergeAttributes(IHTMLElement mergeThis) {}
	public abstract virtual void SetOncontextmenu(object p) {}
	public abstract virtual object GetOncontextmenu() {}
	public abstract virtual IHTMLElement InsertAdjacentElement(string where, IHTMLElement insertedElement) {}
	public abstract virtual IHTMLElement ApplyElement(IHTMLElement apply, string where) {}
	public abstract virtual string GetAdjacentText(string where) {}
	public abstract virtual string ReplaceAdjacentText(string where, string newText) {}
	public abstract virtual bool GetCanHaveChildren() {}
	public abstract virtual int AddBehavior(string bstrUrl, System.Object& pvarFactory) {}
	public abstract virtual bool RemoveBehavior(int cookie) {}
	public abstract virtual IHTMLStyle GetRuntimeStyle() {}
	public abstract virtual object GetBehaviorUrns() {}
	public abstract virtual void SetTagUrn(string p) {}
	public abstract virtual string GetTagUrn() {}
	public abstract virtual void SetOnbeforeeditfocus(object p) {}
	public abstract virtual object GetOnbeforeeditfocus() {}
	public abstract virtual int GetReadyStateValue() {}
	public abstract virtual IHTMLElementCollection GetElementsByTagName(string v) {}
	public abstract virtual IHTMLStyle GetBaseStyle() {}
	public abstract virtual IHTMLCurrentStyle GetBaseCurrentStyle() {}
	public abstract virtual IHTMLStyle GetBaseRuntimeStyle() {}
	public abstract virtual void SetOnmousehover(object p) {}
	public abstract virtual object GetOnmousehover() {}
	public abstract virtual void SetOnkeydownpreview(object p) {}
	public abstract virtual object GetOnkeydownpreview() {}
	public abstract virtual object GetBehavior(string bstrName, string bstrUrn) {}
	public abstract virtual string GetScopeName() {}
	public abstract virtual void SetCapture(bool containerCapture) {}
	public abstract virtual void ReleaseCapture() {}
	public abstract virtual void SetOnlosecapture(object p) {}
	public abstract virtual object GetOnlosecapture() {}
	public abstract virtual string ComponentFromPoint(int x, int y) {}
	public abstract virtual void DoScroll(object component) {}
	public abstract virtual void SetOnscroll(object p) {}
	public abstract virtual object GetOnscroll() {}
	public abstract virtual void SetOndrag(object p) {}
	public abstract virtual object GetOndrag() {}
	public abstract virtual void SetOndragend(object p) {}
	public abstract virtual object GetOndragend() {}
	public abstract virtual void SetOndragenter(object p) {}
	public abstract virtual object GetOndragenter() {}
	public abstract virtual void SetOndragover(object p) {}
	public abstract virtual object GetOndragover() {}
	public abstract virtual void SetOndragleave(object p) {}
	public abstract virtual object GetOndragleave() {}
	public abstract virtual void SetOndrop(object p) {}
	public abstract virtual object GetOndrop() {}
	public abstract virtual void SetOnbeforecut(object p) {}
	public abstract virtual object GetOnbeforecut() {}
	public abstract virtual void SetOncut(object p) {}
	public abstract virtual object GetOncut() {}
	public abstract virtual void SetOnbeforecopy(object p) {}
	public abstract virtual object GetOnbeforecopy() {}
	public abstract virtual void SetOncopy(object p) {}
	public abstract virtual object GetOncopy() {}
	public abstract virtual void SetOnbeforepaste(object p) {}
	public abstract virtual object GetOnbeforepaste() {}
	public abstract virtual void SetOnpaste(object p) {}
	public abstract virtual object GetOnpaste() {}
	public abstract virtual IHTMLCurrentStyle GetCurrentStyle() {}
	public abstract virtual void SetOnpropertychange(object p) {}
	public abstract virtual object GetOnpropertychange() {}
	public abstract virtual IHTMLRectCollection GetClientRects() {}
	public abstract virtual IHTMLRect GetBoundingClientRect() {}
	public abstract virtual void SetExpression(string propname, string expression, string language) {}
	public abstract virtual object GetExpression(object propname) {}
	public abstract virtual bool RemoveExpression(string propname) {}
	public abstract virtual void SetTabIndex(short p) {}
	public abstract virtual short GetTabIndex() {}
	public abstract virtual void Focus() {}
	public abstract virtual void SetAccessKey(string p) {}
	public abstract virtual string GetAccessKey() {}
	public abstract virtual void SetOnblur(object p) {}
	public abstract virtual object GetOnblur() {}
	public abstract virtual void SetOnfocus(object p) {}
	public abstract virtual object GetOnfocus() {}
	public abstract virtual void SetOnresize(object p) {}
	public abstract virtual object GetOnresize() {}
	public abstract virtual void Blur() {}
	public abstract virtual void AddFilter(object pUnk) {}
	public abstract virtual void RemoveFilter(object pUnk) {}
	public abstract virtual int GetClientHeight() {}
	public abstract virtual int GetClientWidth() {}
	public abstract virtual int GetClientTop() {}
	public abstract virtual int GetClientLeft() {}
	public abstract virtual bool AttachEvent(string ev, object pdisp) {}
	public abstract virtual void DetachEvent(string ev, object pdisp) {}
	public abstract virtual object GetReadyState() {}
	public abstract virtual void SetOnreadystatechange(object p) {}
}


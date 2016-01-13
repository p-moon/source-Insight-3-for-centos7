public interface IHTMLElement3
{

	// Methods
	public abstract virtual void MergeAttributes(IHTMLElement mergeThis, object pvarFlags) {}
	public abstract virtual bool GetIsMultiLine() {}
	public abstract virtual bool GetCanHaveHTML() {}
	public abstract virtual void SetOnLayoutComplete(object p) {}
	public abstract virtual object GetOnLayoutComplete() {}
	public abstract virtual void SetOnPage(object p) {}
	public abstract virtual object GetOnPage() {}
	public abstract virtual void SetInflateBlock(bool inflate) {}
	public abstract virtual bool GetInflateBlock() {}
	public abstract virtual void SetOnBeforeDeactivate(object p) {}
	public abstract virtual object GetOnBeforeDeactivate() {}
	public abstract virtual void SetActive() {}
	public abstract virtual void SetContentEditable(string p) {}
	public abstract virtual string GetContentEditable() {}
	public abstract virtual bool GetIsContentEditable() {}
	public abstract virtual void SetHideFocus(bool v) {}
	public abstract virtual bool GetHideFocus() {}
	public abstract virtual void SetDisabled(bool v) {}
	public abstract virtual bool GetDisabled() {}
	public abstract virtual bool GetIsDisabled() {}
	public abstract virtual void SetOnMove(object p) {}
	public abstract virtual object GetOnMove() {}
	public abstract virtual void SetOnControlSelect(object p) {}
	public abstract virtual object GetOnControlSelect() {}
	public abstract virtual bool FireEvent(string eventName, object eventObject) {}
	public abstract virtual void SetOnResizeStart(object p) {}
	public abstract virtual object GetOnResizeStart() {}
	public abstract virtual void SetOnResizeEnd(object p) {}
	public abstract virtual object GetOnResizeEnd() {}
	public abstract virtual void SetOnMoveStart(object p) {}
	public abstract virtual object GetOnMoveStart() {}
	public abstract virtual void SetOnMoveEnd(object p) {}
	public abstract virtual object GetOnMoveEnd() {}
	public abstract virtual void SetOnMouseEnter(object p) {}
	public abstract virtual object GetOnMouseEnter() {}
	public abstract virtual void SetOnMouseLeave(object p) {}
	public abstract virtual object GetOnMouseLeave() {}
	public abstract virtual void SetOnActivate(object p) {}
	public abstract virtual object GetOnActivate() {}
	public abstract virtual void SetOnDeactivate(object p) {}
	public abstract virtual object GetOnDeactivate() {}
	public abstract virtual bool DragDrop() {}
	public abstract virtual int GetGlyphMode() {}
}


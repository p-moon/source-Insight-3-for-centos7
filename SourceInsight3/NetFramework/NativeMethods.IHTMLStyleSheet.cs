public interface IHTMLStyleSheet
{

	// Methods
	public abstract virtual void SetTitle(string p) {}
	public abstract virtual string GetTitle() {}
	public abstract virtual IHTMLStyleSheet GetParentStyleSheet() {}
	public abstract virtual IHTMLElement GetOwningElement() {}
	public abstract virtual void SetDisabled(bool p) {}
	public abstract virtual bool GetDisabled() {}
	public abstract virtual bool GetReadOnly() {}
	public abstract virtual object GetImports() {}
	public abstract virtual void SetHref(string p) {}
	public abstract virtual string GetHref() {}
	public abstract virtual string GetStyleSheetType() {}
	public abstract virtual string GetId() {}
	public abstract virtual int AddImport(string bstrURL, int lIndex) {}
	public abstract virtual int AddRule(string bstrSelector, string bstrStyle, int lIndex) {}
	public abstract virtual void RemoveImport(int lIndex) {}
	public abstract virtual void RemoveRule(int lIndex) {}
	public abstract virtual void SetMedia(string p) {}
	public abstract virtual string GetMedia() {}
	public abstract virtual void SetCssText(string p) {}
	public abstract virtual string GetCssText() {}
	public abstract virtual object GetRules() {}
}


public interface IVsPerPropertyBrowsing
{

	// Methods
	public abstract virtual int HideProperty(int dispid, System.Boolean& pfHide) {}
	public abstract virtual int DisplayChildProperties(int dispid, System.Boolean& pfDisplay) {}
	public abstract virtual int GetLocalizedPropertyInfo(int dispid, int localeIDout , string[] pbstrLocalizedNameout , string[] pbstrLocalizeDescription) {}
	public abstract virtual int HasDefaultValue(int dispid, System.Boolean& fDefault) {}
	public abstract virtual int IsPropertyReadOnly(int dispid, System.Boolean& fReadOnly) {}
	public abstract virtual int GetClassName(out System.String& pbstrClassName) {}
	public abstract virtual int CanResetPropertyValue(int dispidout , System.Boolean& pfCanReset) {}
	public abstract virtual int ResetPropertyValue(int dispid) {}
}


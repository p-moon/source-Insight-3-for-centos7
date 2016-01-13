public class MobileCapabilities : System.Web.HttpBrowserCapabilities, System.Web.UI.IFilterResolutionService
{

	// Constructors
	public MobileCapabilities() {}

	// Methods
	public bool HasCapability(string delegateName, string optionalParameter) {}
	public void DisableOptimizedCacheKey() {}
	public System.Web.UI.HtmlTextWriter CreateHtmlTextWriter(System.IO.TextWriter w) {}
	public System.Version[] GetClrVersions() {}
	public bool IsBrowser(string browserName) {}
	public void AddBrowser(string browserName) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public string PreferredRenderingTypeHtml32;
	public string PreferredRenderingTypeWml11;
	public string PreferredRenderingTypeWml12;
	public string PreferredRenderingTypeChtml10;

	// Properties
	public bool UseOptimizedCacheKey { get{} }
	public string Item { get{} }
	public System.Collections.IDictionary Capabilities { get{} set{} }
	public System.Collections.IDictionary Adapters { get{} }
	public string HtmlTextWriter { get{} set{} }
	public string Id { get{} }
	public System.Collections.ArrayList Browsers { get{} }
	public System.Version ClrVersion { get{} }
	public string Type { get{} }
	public string Browser { get{} }
	public string Version { get{} }
	public int MajorVersion { get{} }
	public string MinorVersionString { get{} }
	public double MinorVersion { get{} }
	public string Platform { get{} }
	public Type TagWriter { get{} }
	public System.Version EcmaScriptVersion { get{} }
	public System.Version MSDomVersion { get{} }
	public System.Version W3CDomVersion { get{} }
	public bool Beta { get{} }
	public bool Crawler { get{} }
	public bool AOL { get{} }
	public bool Win16 { get{} }
	public bool Win32 { get{} }
	public bool Frames { get{} }
	public bool RequiresControlStateInSession { get{} }
	public bool Tables { get{} }
	public bool Cookies { get{} }
	public bool VBScript { get{} }
	public bool JavaScript { get{} }
	public bool JavaApplets { get{} }
	public System.Version JScriptVersion { get{} }
	public bool ActiveXControls { get{} }
	public bool BackgroundSounds { get{} }
	public bool CDF { get{} }
	public string MobileDeviceManufacturer { get{} }
	public string MobileDeviceModel { get{} }
	public string GatewayVersion { get{} }
	public int GatewayMajorVersion { get{} }
	public double GatewayMinorVersion { get{} }
	public string PreferredRenderingType { get{} }
	public string PreferredRequestEncoding { get{} }
	public string PreferredResponseEncoding { get{} }
	public string PreferredRenderingMime { get{} }
	public string PreferredImageMime { get{} }
	public int ScreenCharactersWidth { get{} }
	public int ScreenCharactersHeight { get{} }
	public int ScreenPixelsWidth { get{} }
	public int ScreenPixelsHeight { get{} }
	public int ScreenBitDepth { get{} }
	public bool IsColor { get{} }
	public string InputType { get{} }
	public int NumberOfSoftkeys { get{} }
	public int MaximumSoftkeyLabelLength { get{} }
	public bool CanInitiateVoiceCall { get{} }
	public bool CanSendMail { get{} }
	public bool HasBackButton { get{} }
	public bool RendersWmlDoAcceptsInline { get{} }
	public bool RendersWmlSelectsAsMenuCards { get{} }
	public bool RendersBreaksAfterWmlAnchor { get{} }
	public bool RendersBreaksAfterWmlInput { get{} }
	public bool RendersBreakBeforeWmlSelectAndInput { get{} }
	public bool RequiresPhoneNumbersAsPlainText { get{} }
	public bool RequiresUrlEncodedPostfieldValues { get{} }
	public string RequiredMetaTagNameValue { get{} }
	public bool RendersBreaksAfterHtmlLists { get{} }
	public bool RequiresUniqueHtmlInputNames { get{} }
	public bool RequiresUniqueHtmlCheckboxNames { get{} }
	public bool SupportsCss { get{} }
	public bool HidesRightAlignedMultiselectScrollbars { get{} }
	public bool IsMobileDevice { get{} }
	public bool RequiresAttributeColonSubstitution { get{} }
	public bool CanRenderOneventAndPrevElementsTogether { get{} }
	public bool CanRenderInputAndSelectElementsTogether { get{} }
	public bool CanRenderAfterInputOrSelectElement { get{} }
	public bool CanRenderPostBackCards { get{} }
	public bool CanRenderMixedSelects { get{} }
	public bool CanCombineFormsInDeck { get{} }
	public bool CanRenderSetvarZeroWithMultiSelectionList { get{} }
	public bool SupportsImageSubmit { get{} }
	public bool RequiresUniqueFilePathSuffix { get{} }
	public bool RequiresNoBreakInFormatting { get{} }
	public bool RequiresLeadingPageBreak { get{} }
	public bool SupportsSelectMultiple { get{} }
	public bool SupportsBold { get{} }
	public bool SupportsItalic { get{} }
	public bool SupportsFontSize { get{} }
	public bool SupportsFontName { get{} }
	public bool SupportsFontColor { get{} }
	public bool SupportsBodyColor { get{} }
	public bool SupportsDivAlign { get{} }
	public bool SupportsDivNoWrap { get{} }
	public bool RequiresContentTypeMetaTag { get{} }
	public bool RequiresDBCSCharacter { get{} }
	public bool RequiresHtmlAdaptiveErrorReporting { get{} }
	public bool RequiresOutputOptimization { get{} }
	public bool SupportsAccesskeyAttribute { get{} }
	public bool SupportsInputIStyle { get{} }
	public bool SupportsInputMode { get{} }
	public bool SupportsIModeSymbols { get{} }
	public bool SupportsJPhoneSymbols { get{} }
	public bool SupportsJPhoneMultiMediaAttributes { get{} }
	public int MaximumRenderedPageSize { get{} }
	public bool RequiresSpecialViewStateEncoding { get{} }
	public bool SupportsQueryStringInFormAction { get{} }
	public bool SupportsCacheControlMetaTag { get{} }
	public bool SupportsUncheck { get{} }
	public bool CanRenderEmptySelects { get{} }
	public bool SupportsRedirectWithCookie { get{} }
	public bool SupportsEmptyStringInCookieValue { get{} }
	public int DefaultSubmitButtonLimit { get{} }
	public bool SupportsXmlHttp { get{} }
	public bool SupportsCallback { get{} }
	public int MaximumHrefLength { get{} }
}


public class XhtmlMobileTextWriter : System.Web.UI.MobileControls.Adapters.MobileTextWriter, System.IDisposable
{

	// Constructors
	public XhtmlMobileTextWriter(System.IO.TextWriter writer, System.Web.Mobile.MobileCapabilities device) {}

	// Methods
	public virtual void AddOnEnterForwardSetVar(string var) {}
	public virtual void AddOnEnterForwardSetVar(string var, string value) {}
	public virtual void BeginCachedRendering() {}
	public virtual void ClearPendingBreak() {}
	public virtual void EndCachedRendering() {}
	public virtual void EnterFormat(System.Web.UI.MobileControls.Style style) {}
	public virtual void EnterLayout(System.Web.UI.MobileControls.Style style) {}
	public void EnterStyle(System.Web.UI.MobileControls.Style style) {}
	public virtual void ExitFormat(System.Web.UI.MobileControls.Style style) {}
	public virtual void ExitFormat(System.Web.UI.MobileControls.Style style, bool breakafter) {}
	public virtual void ExitLayout(System.Web.UI.MobileControls.Style style) {}
	public virtual void ExitLayout(System.Web.UI.MobileControls.Style style, bool breakafter) {}
	public void ExitStyle(System.Web.UI.MobileControls.Style style) {}
	public virtual bool IsStyleSheetEmpty() {}
	public virtual void MarkWmlOnEventLocation() {}
	public virtual void SetBodyStyle(System.Web.UI.MobileControls.Style style) {}
	public virtual void SetCacheKey(System.Web.Caching.Cache cache) {}
	public virtual void SetPendingBreak() {}
	public virtual void SetSessionKey(System.Web.SessionState.HttpSessionState session) {}
	public virtual void WriteAttribute(string attribute, string value, bool encode) {}
	public virtual void WriteBeginTag(string tag) {}
	public virtual void WriteBreak() {}
	public virtual void WriteCachedMarkup() {}
	public virtual void WriteDoctypeDeclaration(Doctype type) {}
	public virtual void WriteEncodedAttributeValue(string value) {}
	public virtual void WriteEndTag(string tag) {}
	public virtual void WriteFullBeginTag(string tag) {}
	public virtual void WriteHiddenField(string name, string value) {}
	public virtual void WriteHiddenField(string name) {}
	public virtual void WriteLine() {}
	public virtual void WriteLine(string format, object[] arg) {}
	public virtual void WriteLine(string format, object arg) {}
	public virtual void WriteLine(string format, object arg0, object arg1) {}
	public virtual void WriteLine(object v) {}
	public virtual void WriteLine(string s) {}
	public virtual void WriteLine(double v) {}
	public virtual void WriteLine(float v) {}
	public virtual void WriteLine(long v) {}
	public virtual void WriteLine(int v) {}
	public virtual void WriteLine(bool v) {}
	public virtual void WriteLine(char[] buffer, int index, int count) {}
	public virtual void WriteLine(char[] v) {}
	public virtual void WriteLine(char v) {}
	public virtual void WritePendingBreak() {}
	public virtual void WriteUrlParameter(string name, string value) {}
	public virtual void WriteXmlDeclaration() {}
	public void EnterStyle(System.Web.UI.MobileControls.Style style) {}
	public void ExitStyle(System.Web.UI.MobileControls.Style style) {}
	public virtual void BeginResponse() {}
	public virtual void EndResponse() {}
	public virtual void BeginFile(string url, string contentType, string charset) {}
	public virtual void EndFile() {}
	public virtual void AddResource(string url, string contentType) {}
	public virtual string NewUrl(string filetype) {}
	public void AddResource(string url) {}
	public virtual void EnterStyle(System.Web.UI.WebControls.Style style, System.Web.UI.HtmlTextWriterTag tag) {}
	public virtual void ExitStyle(System.Web.UI.WebControls.Style style, System.Web.UI.HtmlTextWriterTag tag) {}
	public virtual bool IsValidFormAttribute(string attribute) {}
	public virtual void BeginRender() {}
	public virtual void Close() {}
	public virtual void EndRender() {}
	public virtual void EnterStyle(System.Web.UI.WebControls.Style style) {}
	public virtual void ExitStyle(System.Web.UI.WebControls.Style style) {}
	public virtual void Flush() {}
	public virtual void Write(string s) {}
	public virtual void Write(bool value) {}
	public virtual void Write(char value) {}
	public virtual void Write(char[] buffer) {}
	public virtual void Write(char[] buffer, int index, int count) {}
	public virtual void Write(double value) {}
	public virtual void Write(float value) {}
	public virtual void Write(int value) {}
	public virtual void Write(long value) {}
	public virtual void Write(object value) {}
	public virtual void Write(string format, object arg0) {}
	public virtual void Write(string format, object arg0, object arg1) {}
	public virtual void Write(string format, object[] arg) {}
	public void WriteLineNoTabs(string s) {}
	public virtual void WriteLine(uint value) {}
	public virtual void AddAttribute(string name, string value) {}
	public virtual void AddAttribute(string name, string value, bool fEndode) {}
	public virtual void AddAttribute(System.Web.UI.HtmlTextWriterAttribute key, string value) {}
	public virtual void AddAttribute(System.Web.UI.HtmlTextWriterAttribute key, string value, bool fEncode) {}
	public virtual void AddStyleAttribute(string name, string value) {}
	public virtual void AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle key, string value) {}
	public virtual void RenderBeginTag(string tagName) {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriterTag tagKey) {}
	public virtual void RenderEndTag() {}
	public virtual void WriteAttribute(string name, string value) {}
	public virtual void WriteBreak() {}
	public virtual void WriteStyleAttribute(string name, string value) {}
	public virtual void WriteStyleAttribute(string name, string value, bool fEncode) {}
	public virtual void WriteEncodedUrl(string url) {}
	public virtual void WriteEncodedUrlParameter(string urlText) {}
	public virtual void WriteEncodedText(string text) {}
	public virtual void Dispose() {}
	public virtual void Write(uint value) {}
	public virtual void Write(ulong value) {}
	public virtual void Write(decimal value) {}
	public virtual void Write(string format, object arg0, object arg1, object arg2) {}
	public virtual void WriteLine(ulong value) {}
	public virtual void WriteLine(decimal value) {}
	public virtual void WriteLine(string format, object arg0, object arg1, object arg2) {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string CacheKey { get{} }
	public string CustomBodyStyles { get{} set{} }
	public string SessionKey { get{} }
	public bool SupportsNoWrapStyle { get{} set{} }
	public bool SuppressNewLine { get{} set{} }
	public bool UseDivsForBreaks { get{} set{} }
	public System.Web.Mobile.MobileCapabilities Device { get{} }
	public bool SupportsMultiPart { get{} }
	public System.Text.Encoding Encoding { get{} }
	public string NewLine { get{} set{} }
	public int Indent { get{} set{} }
	public System.IO.TextWriter InnerWriter { get{} set{} }
	public System.IFormatProvider FormatProvider { get{} }
}


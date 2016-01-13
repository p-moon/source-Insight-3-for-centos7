public class WmlMobileTextWriter : MobileTextWriter, System.IDisposable
{

	// Constructors
	public WmlMobileTextWriter(System.IO.TextWriter writer, System.Web.Mobile.MobileCapabilities device, System.Web.UI.MobileControls.MobilePage page) {}

	// Methods
	public virtual void EnterLayout(System.Web.UI.MobileControls.Style style) {}
	public virtual void ExitLayout(System.Web.UI.MobileControls.Style style, bool breakAfter) {}
	public virtual void EnterFormat(System.Web.UI.MobileControls.Style style) {}
	public virtual void ExitFormat(System.Web.UI.MobileControls.Style style) {}
	public virtual void BeginForm(System.Web.UI.MobileControls.Form form) {}
	public virtual void EndForm() {}
	public void RenderText(string text) {}
	public void RenderText(string text, bool breakAfter) {}
	public virtual void RenderText(string text, bool breakAfter, bool encodeText) {}
	public virtual void RenderBeginHyperlink(string targetUrl, bool encodeUrl, string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey) {}
	public virtual void RenderEndHyperlink(bool breakAfter) {}
	public virtual void RenderTextBox(string id, string value, string format, string title, bool password, int size, int maxLength, bool generateRandomID, bool breakAfter) {}
	public virtual void RenderImage(string source, string localSource, string alternateText, bool breakAfter) {}
	public virtual void RenderBeginPostBack(string softkeyLabel, bool implicitSoftkeyLabel, bool mapToSoftkey) {}
	public virtual void RenderEndPostBack(string target, string argument, WmlPostFieldType postBackType, bool includeVariables, bool breakAfter) {}
	public virtual void RenderBeginSelect(string name, string iname, string ivalue, string title, bool multiSelect) {}
	public virtual void RenderEndSelect(bool breakAfter) {}
	public virtual void RenderSelectOption(string text) {}
	public virtual void RenderSelectOption(string text, string value) {}
	public virtual void BeginCustomMarkup() {}
	public virtual void EndCustomMarkup() {}
	public void AddFormVariable(string clientID, string value, bool generateRandomID) {}
	public virtual void ResetFormattingState() {}
	public virtual void RenderExtraCards() {}
	public virtual bool IsValidSoftkeyLabel(string label) {}
	public virtual void RenderGoAction(string target, string argument, WmlPostFieldType postBackType, bool includeVariables) {}
	public virtual void WriteAttribute(string attribute, string value, bool encode) {}
	public virtual void WriteEncodedUrl(string url) {}
	public virtual void WriteEncodedText(string text) {}
	public void WriteText(string text, bool encodeText) {}
	public void WritePostField(string name, string value) {}
	public void WritePostFieldVariable(string name, string arg) {}
	public void WritePostField(string name, string value, WmlPostFieldType type) {}
	public virtual void ExitLayout(System.Web.UI.MobileControls.Style style) {}
	public virtual void ExitFormat(System.Web.UI.MobileControls.Style style, bool breakAfter) {}
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
	public virtual void WriteLine(string s) {}
	public virtual void WriteLine() {}
	public virtual void WriteLine(bool value) {}
	public virtual void WriteLine(char value) {}
	public virtual void WriteLine(char[] buffer) {}
	public virtual void WriteLine(char[] buffer, int index, int count) {}
	public virtual void WriteLine(double value) {}
	public virtual void WriteLine(float value) {}
	public virtual void WriteLine(int value) {}
	public virtual void WriteLine(long value) {}
	public virtual void WriteLine(object value) {}
	public virtual void WriteLine(string format, object arg0) {}
	public virtual void WriteLine(string format, object arg0, object arg1) {}
	public virtual void WriteLine(string format, object[] arg) {}
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
	public virtual void WriteBeginTag(string tagName) {}
	public virtual void WriteBreak() {}
	public virtual void WriteFullBeginTag(string tagName) {}
	public virtual void WriteEndTag(string tagName) {}
	public virtual void WriteStyleAttribute(string name, string value) {}
	public virtual void WriteStyleAttribute(string name, string value, bool fEncode) {}
	public virtual void WriteEncodedUrlParameter(string urlText) {}
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
	public bool AnalyzeMode { get{} set{} }
	public System.Web.Mobile.MobileCapabilities Device { get{} }
	public bool SupportsMultiPart { get{} }
	public System.Text.Encoding Encoding { get{} }
	public string NewLine { get{} set{} }
	public int Indent { get{} set{} }
	public System.IO.TextWriter InnerWriter { get{} set{} }
	public System.IFormatProvider FormatProvider { get{} }
}


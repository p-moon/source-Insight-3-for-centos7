public class HtmlDocument
{

	// Methods
	public void Write(string text) {}
	public void ExecCommand(string command, bool showUI, object value) {}
	public void Focus() {}
	public HtmlElement GetElementById(string id) {}
	public HtmlElement GetElementFromPoint(System.Drawing.Point point) {}
	public HtmlElementCollection GetElementsByTagName(string tagName) {}
	public HtmlDocument OpenNew(bool replaceInHistory) {}
	public HtmlElement CreateElement(string elementTag) {}
	public object InvokeScript(string scriptName, object[] args) {}
	public object InvokeScript(string scriptName) {}
	public void AttachEventHandler(string eventName, System.EventHandler eventHandler) {}
	public void DetachEventHandler(string eventName, System.EventHandler eventHandler) {}
	public static bool op_Equality(HtmlDocument left, HtmlDocument right) {}
	public static bool op_Inequality(HtmlDocument left, HtmlDocument right) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public HtmlElement ActiveElement { get{} }
	public HtmlElement Body { get{} }
	public string Domain { get{} set{} }
	public string Title { get{} set{} }
	public System.Uri Url { get{} }
	public HtmlWindow Window { get{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Drawing.Color LinkColor { get{} set{} }
	public System.Drawing.Color ActiveLinkColor { get{} set{} }
	public System.Drawing.Color VisitedLinkColor { get{} set{} }
	public bool Focused { get{} }
	public object DomDocument { get{} }
	public string Cookie { get{} set{} }
	public bool RightToLeft { get{} set{} }
	public string Encoding { get{} set{} }
	public string DefaultEncoding { get{} }
	public HtmlElementCollection All { get{} }
	public HtmlElementCollection Links { get{} }
	public HtmlElementCollection Images { get{} }
	public HtmlElementCollection Forms { get{} }

	// Events
	public event System.Windows.Forms.HtmlElementEventHandler Click;
	public event System.Windows.Forms.HtmlElementEventHandler ContextMenuShowing;
	public event System.Windows.Forms.HtmlElementEventHandler Focusing;
	public event System.Windows.Forms.HtmlElementEventHandler LosingFocus;
	public event System.Windows.Forms.HtmlElementEventHandler MouseDown;
	public event System.Windows.Forms.HtmlElementEventHandler MouseLeave;
	public event System.Windows.Forms.HtmlElementEventHandler MouseMove;
	public event System.Windows.Forms.HtmlElementEventHandler MouseOver;
	public event System.Windows.Forms.HtmlElementEventHandler MouseUp;
	public event System.Windows.Forms.HtmlElementEventHandler Stop;
}


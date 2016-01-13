public class HtmlElement
{

	// Methods
	public HtmlElement AppendChild(HtmlElement newElement) {}
	public void AttachEventHandler(string eventName, System.EventHandler eventHandler) {}
	public void DetachEventHandler(string eventName, System.EventHandler eventHandler) {}
	public void Focus() {}
	public string GetAttribute(string attributeName) {}
	public HtmlElementCollection GetElementsByTagName(string tagName) {}
	public HtmlElement InsertAdjacentElement(HtmlElementInsertionOrientation orient, HtmlElement newElement) {}
	public object InvokeMember(string methodName) {}
	public object InvokeMember(string methodName, object[] parameter) {}
	public void RemoveFocus() {}
	public void RaiseEvent(string eventName) {}
	public void ScrollIntoView(bool alignWithTop) {}
	public void SetAttribute(string attributeName, string value) {}
	public static bool op_Equality(HtmlElement left, HtmlElement right) {}
	public static bool op_Inequality(HtmlElement left, HtmlElement right) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public HtmlElementCollection All { get{} }
	public HtmlElementCollection Children { get{} }
	public bool CanHaveChildren { get{} }
	public System.Drawing.Rectangle ClientRectangle { get{} }
	public HtmlDocument Document { get{} }
	public bool Enabled { get{} set{} }
	public HtmlElement FirstChild { get{} }
	public string Id { get{} set{} }
	public string InnerHtml { get{} set{} }
	public string InnerText { get{} set{} }
	public string Name { get{} set{} }
	public HtmlElement NextSibling { get{} }
	public System.Drawing.Rectangle OffsetRectangle { get{} }
	public HtmlElement OffsetParent { get{} }
	public string OuterHtml { get{} set{} }
	public string OuterText { get{} set{} }
	public HtmlElement Parent { get{} }
	public System.Drawing.Rectangle ScrollRectangle { get{} }
	public int ScrollLeft { get{} set{} }
	public int ScrollTop { get{} set{} }
	public string Style { get{} set{} }
	public string TagName { get{} }
	public short TabIndex { get{} set{} }
	public object DomElement { get{} }

	// Events
	public event System.Windows.Forms.HtmlElementEventHandler Click;
	public event System.Windows.Forms.HtmlElementEventHandler DoubleClick;
	public event System.Windows.Forms.HtmlElementEventHandler Drag;
	public event System.Windows.Forms.HtmlElementEventHandler DragEnd;
	public event System.Windows.Forms.HtmlElementEventHandler DragLeave;
	public event System.Windows.Forms.HtmlElementEventHandler DragOver;
	public event System.Windows.Forms.HtmlElementEventHandler Focusing;
	public event System.Windows.Forms.HtmlElementEventHandler GotFocus;
	public event System.Windows.Forms.HtmlElementEventHandler LosingFocus;
	public event System.Windows.Forms.HtmlElementEventHandler LostFocus;
	public event System.Windows.Forms.HtmlElementEventHandler KeyDown;
	public event System.Windows.Forms.HtmlElementEventHandler KeyPress;
	public event System.Windows.Forms.HtmlElementEventHandler KeyUp;
	public event System.Windows.Forms.HtmlElementEventHandler MouseMove;
	public event System.Windows.Forms.HtmlElementEventHandler MouseDown;
	public event System.Windows.Forms.HtmlElementEventHandler MouseOver;
	public event System.Windows.Forms.HtmlElementEventHandler MouseUp;
	public event System.Windows.Forms.HtmlElementEventHandler MouseEnter;
	public event System.Windows.Forms.HtmlElementEventHandler MouseLeave;
}


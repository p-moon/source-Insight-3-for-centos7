public class HtmlWindow
{

	// Methods
	public void Alert(string message) {}
	public void AttachEventHandler(string eventName, System.EventHandler eventHandler) {}
	public void Close() {}
	public bool Confirm(string message) {}
	public void DetachEventHandler(string eventName, System.EventHandler eventHandler) {}
	public void Focus() {}
	public void MoveTo(int x, int y) {}
	public void MoveTo(System.Drawing.Point point) {}
	public void Navigate(System.Uri url) {}
	public void Navigate(string urlString) {}
	public HtmlWindow Open(string urlString, string target, string windowOptions, bool replaceEntry) {}
	public HtmlWindow Open(System.Uri url, string target, string windowOptions, bool replaceEntry) {}
	public HtmlWindow OpenNew(string urlString, string windowOptions) {}
	public HtmlWindow OpenNew(System.Uri url, string windowOptions) {}
	public string Prompt(string message, string defaultInputValue) {}
	public void RemoveFocus() {}
	public void ResizeTo(int width, int height) {}
	public void ResizeTo(System.Drawing.Size size) {}
	public void ScrollTo(int x, int y) {}
	public void ScrollTo(System.Drawing.Point point) {}
	public static bool op_Equality(HtmlWindow left, HtmlWindow right) {}
	public static bool op_Inequality(HtmlWindow left, HtmlWindow right) {}
	public virtual int GetHashCode() {}
	public virtual bool Equals(object obj) {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public HtmlDocument Document { get{} }
	public object DomWindow { get{} }
	public HtmlWindowCollection Frames { get{} }
	public HtmlHistory History { get{} }
	public bool IsClosed { get{} }
	public string Name { get{} set{} }
	public HtmlWindow Opener { get{} }
	public HtmlWindow Parent { get{} }
	public System.Drawing.Point Position { get{} }
	public System.Drawing.Size Size { get{} set{} }
	public string StatusBarText { get{} set{} }
	public System.Uri Url { get{} }
	public HtmlElement WindowFrameElement { get{} }

	// Events
	public event System.Windows.Forms.HtmlElementErrorEventHandler Error;
	public event System.Windows.Forms.HtmlElementEventHandler GotFocus;
	public event System.Windows.Forms.HtmlElementEventHandler Load;
	public event System.Windows.Forms.HtmlElementEventHandler LostFocus;
	public event System.Windows.Forms.HtmlElementEventHandler Resize;
	public event System.Windows.Forms.HtmlElementEventHandler Scroll;
	public event System.Windows.Forms.HtmlElementEventHandler Unload;
}


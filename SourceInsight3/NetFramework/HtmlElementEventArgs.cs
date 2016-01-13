public class HtmlElementEventArgs : System.EventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public MouseButtons MouseButtonsPressed { get{} }
	public System.Drawing.Point ClientMousePosition { get{} }
	public System.Drawing.Point OffsetMousePosition { get{} }
	public System.Drawing.Point MousePosition { get{} }
	public bool BubbleEvent { get{} set{} }
	public int KeyPressedCode { get{} }
	public bool AltKeyPressed { get{} }
	public bool CtrlKeyPressed { get{} }
	public bool ShiftKeyPressed { get{} }
	public string EventType { get{} }
	public bool ReturnValue { get{} set{} }
	public HtmlElement FromElement { get{} }
	public HtmlElement ToElement { get{} }
}


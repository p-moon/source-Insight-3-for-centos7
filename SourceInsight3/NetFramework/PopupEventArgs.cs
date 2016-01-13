public class PopupEventArgs : System.ComponentModel.CancelEventArgs
{

	// Constructors
	public PopupEventArgs(IWin32Window associatedWindow, Control associatedControl, bool isBalloon, System.Drawing.Size size) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public IWin32Window AssociatedWindow { get{} }
	public Control AssociatedControl { get{} }
	public bool IsBalloon { get{} }
	public System.Drawing.Size ToolTipSize { get{} set{} }
	public bool Cancel { get{} set{} }
}


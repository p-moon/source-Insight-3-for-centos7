public class UICuesEventArgs : System.EventArgs
{

	// Constructors
	public UICuesEventArgs(UICues uicues) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool ShowFocus { get{} }
	public bool ShowKeyboard { get{} }
	public bool ChangeFocus { get{} }
	public bool ChangeKeyboard { get{} }
	public UICues Changed { get{} }
}


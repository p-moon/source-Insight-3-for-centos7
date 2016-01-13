public class KeyEventArgs : System.EventArgs
{

	// Constructors
	public KeyEventArgs(Keys keyData) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Alt { get{} }
	public bool Control { get{} }
	public bool Handled { get{} set{} }
	public Keys KeyCode { get{} }
	public int KeyValue { get{} }
	public Keys KeyData { get{} }
	public Keys Modifiers { get{} }
	public bool Shift { get{} }
	public bool SuppressKeyPress { get{} set{} }
}


public class PreviewKeyDownEventArgs : System.EventArgs
{

	// Constructors
	public PreviewKeyDownEventArgs(Keys keyData) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Alt { get{} }
	public bool Control { get{} }
	public Keys KeyCode { get{} }
	public int KeyValue { get{} }
	public Keys KeyData { get{} }
	public Keys Modifiers { get{} }
	public bool Shift { get{} }
	public bool IsInputKey { get{} set{} }
}


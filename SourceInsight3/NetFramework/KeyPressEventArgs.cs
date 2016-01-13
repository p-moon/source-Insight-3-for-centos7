public class KeyPressEventArgs : System.EventArgs
{

	// Constructors
	public KeyPressEventArgs(char keyChar) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public char KeyChar { get{} set{} }
	public bool Handled { get{} set{} }
}


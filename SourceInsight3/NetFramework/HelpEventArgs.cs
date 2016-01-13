public class HelpEventArgs : System.EventArgs
{

	// Constructors
	public HelpEventArgs(System.Drawing.Point mousePos) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Drawing.Point MousePos { get{} }
	public bool Handled { get{} set{} }
}


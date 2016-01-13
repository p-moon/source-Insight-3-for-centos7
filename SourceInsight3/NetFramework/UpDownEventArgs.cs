public class UpDownEventArgs : System.EventArgs
{

	// Constructors
	public UpDownEventArgs(int buttonPushed) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ButtonID { get{} }
}


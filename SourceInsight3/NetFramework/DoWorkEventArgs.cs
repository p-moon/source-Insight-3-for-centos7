public class DoWorkEventArgs : CancelEventArgs
{

	// Constructors
	public DoWorkEventArgs(object argument) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Argument { get{} }
	public object Result { get{} set{} }
	public bool Cancel { get{} set{} }
}


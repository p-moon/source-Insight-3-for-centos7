public class ConvertEventArgs : System.EventArgs
{

	// Constructors
	public ConvertEventArgs(object value, Type desiredType) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object Value { get{} set{} }
	public Type DesiredType { get{} }
}


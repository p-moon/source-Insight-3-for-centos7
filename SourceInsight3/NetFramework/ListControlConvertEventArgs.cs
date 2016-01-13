public class ListControlConvertEventArgs : ConvertEventArgs
{

	// Constructors
	public ListControlConvertEventArgs(object value, Type desiredType, object listItem) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public object ListItem { get{} }
	public object Value { get{} set{} }
	public Type DesiredType { get{} }
}


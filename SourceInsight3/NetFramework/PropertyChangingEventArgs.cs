public class PropertyChangingEventArgs : System.EventArgs
{

	// Constructors
	public PropertyChangingEventArgs(string propertyName) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string PropertyName { get{} }
}


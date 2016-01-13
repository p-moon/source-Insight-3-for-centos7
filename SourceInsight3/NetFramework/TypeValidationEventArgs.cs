public class TypeValidationEventArgs : System.EventArgs
{

	// Constructors
	public TypeValidationEventArgs(Type validatingType, bool isValidInput, object returnValue, string message) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool Cancel { get{} set{} }
	public bool IsValidInput { get{} }
	public string Message { get{} }
	public object ReturnValue { get{} }
	public Type ValidatingType { get{} }
}


public class ServerFault
{

	// Constructors
	public ServerFault(string exceptionType, string message, string stackTrace) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ExceptionType { get{} set{} }
	public string ExceptionMessage { get{} set{} }
	public string StackTrace { get{} set{} }
}


public class NotFiniteNumberException : ArithmeticException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public NotFiniteNumberException() {}
	public NotFiniteNumberException(double offendingNumber) {}
	public NotFiniteNumberException(string message) {}
	public NotFiniteNumberException(string message, double offendingNumber) {}
	public NotFiniteNumberException(string message, Exception innerException) {}
	public NotFiniteNumberException(string message, double offendingNumber, Exception innerException) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public double OffendingNumber { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}


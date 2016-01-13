public class RegistrationErrorInfo
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string MajorRef { get{} }
	public string MinorRef { get{} }
	public string Name { get{} }
	public int ErrorCode { get{} }
	public string ErrorString { get{} }
}


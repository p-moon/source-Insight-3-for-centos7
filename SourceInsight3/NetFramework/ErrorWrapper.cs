public class ErrorWrapper
{

	// Constructors
	public ErrorWrapper(int errorCode) {}
	public ErrorWrapper(object errorCode) {}
	public ErrorWrapper(System.Exception e) {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ErrorCode { get{} }
}


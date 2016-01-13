public class WebThreadInformation
{

	// Methods
	public void FormatToString(WebEventFormatter formatter) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ThreadID { get{} }
	public string ThreadAccountName { get{} }
	public string StackTrace { get{} }
	public bool IsImpersonating { get{} }
}


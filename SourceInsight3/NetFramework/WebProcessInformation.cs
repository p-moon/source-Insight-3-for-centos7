public class WebProcessInformation
{

	// Methods
	public void FormatToString(WebEventFormatter formatter) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public int ProcessID { get{} }
	public string ProcessName { get{} }
	public string AccountName { get{} }
}


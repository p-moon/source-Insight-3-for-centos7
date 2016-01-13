public class WebApplicationInformation
{

	// Methods
	public void FormatToString(WebEventFormatter formatter) {}
	public virtual string ToString() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string ApplicationDomain { get{} }
	public string TrustLevel { get{} }
	public string ApplicationVirtualPath { get{} }
	public string ApplicationPath { get{} }
	public string MachineName { get{} }
}


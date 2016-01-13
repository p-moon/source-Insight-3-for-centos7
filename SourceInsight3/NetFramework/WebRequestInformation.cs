public class WebRequestInformation
{

	// Methods
	public void FormatToString(WebEventFormatter formatter) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string RequestUrl { get{} }
	public string RequestPath { get{} }
	public System.Security.Principal.IPrincipal Principal { get{} }
	public string UserHostAddress { get{} }
	public string ThreadAccountName { get{} }
}


public class WebServiceProtocols : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public int value__;
	public WebServiceProtocols Unknown;
	public WebServiceProtocols HttpSoap;
	public WebServiceProtocols HttpGet;
	public WebServiceProtocols HttpPost;
	public WebServiceProtocols Documentation;
	public WebServiceProtocols HttpPostLocalhost;
	public WebServiceProtocols HttpSoap12;
	public WebServiceProtocols AnyHttpSoap;
}

